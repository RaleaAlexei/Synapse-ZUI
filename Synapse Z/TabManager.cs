using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Manina.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;
using Formatting = Newtonsoft.Json.Formatting;
using Pen = System.Drawing.Pen;

namespace Synapse_Z
{
    internal class TabData
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
    }
    internal class TabManager
    {

        private Microsoft.Web.WebView2.WinForms.WebView2 currentWebView2;
        private List<TabData> tabDatas;
        public TabData currentTab;
        public string tabsFolderPath;
        private Manina.Windows.Forms.TabControl tabControl;
        private ContextMenuStrip tabContextMenu;
        private Form currentForm;
        private Manina.Windows.Forms.Tab addTabButton;

        public TabManager(Form form, Manina.Windows.Forms.TabControl tabControl, Microsoft.Web.WebView2.WinForms.WebView2 webview2)
        {
            this.currentForm = form;
            this.tabControl = tabControl;
            this.currentWebView2 = webview2;
            // Initialize tab control
            this.tabControl.Padding = new Padding(22, 4, 22, 4);
            //tabControl1.BackColor = Color.FromArgb(61, 61, 61);
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.ShowCloseTabButtons = true;
            this.tabControl.CloseTabButtonClick += TabControl_CloseTabButtonClick;
            this.tabControl.TabClick += TabControl_TabClick;
            this.tabControl.LayoutTabs += TabControl_LayoutTabs;
            this.tabControl.PageChanged += new System.EventHandler<Manina.Windows.Forms.PageChangedEventArgs>(this.TabControl_PageChanged);
            this.tabControl.PageChanged += TabControl_PageChanged;
            this.tabControl.ForeColor = ThemeManager.Instance.GetThemeColor("SynapseZ.TabControl.ForeColor"); // Set tab text color to white
            this.tabControl.MouseUp += TabControl_MouseUp; // Add MouseUp event for showing context menu
            this.tabDatas = new List<TabData>();
            InitializeTabContextMenu();
            tabsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", "tabs");

            if (!Directory.Exists(tabsFolderPath))
            {
                Directory.CreateDirectory(tabsFolderPath);
            }
            LoadSavedTabs();

        }
        public async Task<string> ReadCurrentWebViewText()
        {
            if (currentWebView2 != null && currentWebView2.CoreWebView2 != null)
            {
                string script = "GetText();";
                string result = await currentWebView2.CoreWebView2.ExecuteScriptAsync(script);
                if (!string.IsNullOrEmpty(result) && result != "null")
                {
                    result = result.Trim('"');
                    return Regex.Unescape(result);
                }
            }
            return string.Empty;
        }

        public async void SetCurrentWebViewText(string text)
        {
            if (currentWebView2 != null && currentWebView2.CoreWebView2 != null)
            {
                string script = $"SetText(`{WebViewManager.EscapeJavaScriptString(text)}`);";
                await currentWebView2.CoreWebView2.ExecuteScriptAsync(script);
            }
        }
        private void InitializeTabContextMenu()
        {
            tabContextMenu = new ContextMenuStrip();

            // Save Tab Menu Item
            ToolStripMenuItem saveTabMenuItem = new ToolStripMenuItem("Save Tab");
            saveTabMenuItem.Click += SaveTabMenuItem_Click;
            tabContextMenu.Items.Add(saveTabMenuItem);

            // Rename Tab Menu Item
            ToolStripMenuItem renameTabMenuItem = new ToolStripMenuItem("Rename Tab");
            renameTabMenuItem.Click += RenameTabMenuItem_Click;
            tabContextMenu.Items.Add(renameTabMenuItem);

            // Clear Tabs Menu Item
            ToolStripMenuItem clearTabsMenuItem = new ToolStripMenuItem("Clear Tabs");
            clearTabsMenuItem.Click += ClearTabsMenuItem_Click;
            tabContextMenu.Items.Add(clearTabsMenuItem);
        }



        #region TabControls


        private void LoadSavedTabs()
        {
            var tabFiles = Directory.GetFiles(tabsFolderPath, "*.json");
            if (tabFiles.Length == 0)
            {
                AddNewTab("Script 1");
                return;
            }
            foreach (var tabFile in tabFiles)
            {
                var tabData = JsonConvert.DeserializeObject<TabData>(File.ReadAllText(tabFile));
                AddNewTab(tabData.Name, tabData.Content, tabData.Guid);
            }
        }

        private void SaveTabContent(TabData tab)
        {
            var json = JsonConvert.SerializeObject(tab, Formatting.Indented);
            File.WriteAllText(Path.Combine(tabsFolderPath, $"{tab.Guid}.json"), json);
        }

        private void DeleteTabFile(string GUID)
        {
            try
            {
                var path = Path.Join(tabsFolderPath, $"{GUID}.json");
                var tabData = JsonConvert.DeserializeObject<TabData>(File.ReadAllText(path));
                if (tabData.Guid == GUID)
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex) { }
        }

        public async Task SaveAllTabsAsync()
        {
            foreach (TabData tab in tabDatas)
            {
                SaveTabContent(tab);
            }
        }
        private async void ClearAllTabs()
        {
            tabDatas.Clear();
            // Collect all tabs except the add tab button
            var tabsToRemove = tabControl.Tabs.Where(tab => tab.Text != "+").ToList();

            // Remove the collected tabs
            foreach (var tab in tabsToRemove)
            {
                try
                {
                    tabControl.Tabs.Remove(tab);
                }
                catch (ArgumentOutOfRangeException)
                {
                    // Ignore the error and continue
                }
            }
            await Task.Delay(1); // Add a slight delay
            // Clear all tab files
            var tabFiles = Directory.GetFiles(tabsFolderPath, "*.json");
            foreach (var tabFile in tabFiles)
            {
                File.Delete(tabFile);
            }
        }

        /// <summary>
        /// Method AddNewTabButton adds the button that will add the "+" button that adds new tabs.
        /// </summary>
        public void AddNewTabButton()
        {
            Color currentColor = tabControl.BackColor;

            // Add 8 to each RGB component, ensuring the values remain within the valid range (0-255)
            int newRed = Math.Min(currentColor.R + 8, 255);
            int newGreen = Math.Min(currentColor.G + 8, 255);
            int newBlue = Math.Min(currentColor.B + 8, 255);

            // Create a new Color with the updated RGB values
            Color newColor = Color.FromArgb(newRed, newGreen, newBlue);

            addTabButton = new Manina.Windows.Forms.Tab
            {
                Text = "+",
                BackColor = newColor,

                ForeColor = ThemeManager.Instance.GetThemeColor("SynapseZ.TabControl.ForeColor"), // Set add button text color to white
                Width = tabControl.TabSize.Height, // Make the add button a perfect square
                Height = tabControl.TabSize.Height
            };

            tabControl.Tabs.Add(addTabButton);
        }

        /// <summary>
        /// Method PositionAddTabButton positions the add button.
        /// </summary>
        private void PositionAddTabButton()
        {
            // Ensure the add tab button is always the last tab
            if (tabControl.Tabs.Contains(addTabButton))
            {
                tabControl.Tabs.Remove(addTabButton);
                tabControl.Tabs.Add(addTabButton);
            }
        }
        /// <summary>
        /// Method AddNewTab adds a new tab with the given name, content and file.
        /// </summary>
        /// <param name="tabName">The tab name</param>
        /// <param name="tabContent">The text that it hold by defualt</param>
        /// <param name="fileName">The file name assigned to it</param>
        public async void AddNewTab(string tabName = null, string tabContent = null, string tabGUID = null)
        {
            await Task.Delay(1); // Add a slight delay
            int scriptNumber = tabDatas.Count;
            string baseTabText = tabName ?? $"Script {scriptNumber + 1}";
            string tabText = baseTabText;
            int count = 1;

            // Ensure the tab name is unique
            while (tabControl.Tabs.Any(tab => tab.Text == tabText))
            {
                tabText = $"{baseTabText} ({count})";
                count++;
            }

            Color currentColor = tabControl.BackColor;

            // Add 8 to each RGB component, ensuring the values remain within the valid range (0-255)
            int newRed = Math.Min(currentColor.R + 68, 255);
            int newGreen = Math.Min(currentColor.G + 68, 255);
            int newBlue = Math.Min(currentColor.B + 68, 255);

            // Create a new Color with the updated RGB values
            Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
            var id = tabGUID ?? Guid.NewGuid().ToString();

            Manina.Windows.Forms.Tab newTab = new Manina.Windows.Forms.Tab
            {
                Name = id,
                Text = tabText,
                BackColor = newColor,
                ForeColor = ThemeManager.Instance.GetThemeColor("SynapseZ.TabControl.ForeColor"), // Set tab text color to white
            };

            tabDatas.Add(new TabData()
            {
                Guid = id,
                Name = tabText,
                Content = tabContent,
            });
            Manina.Windows.Forms.Tab oldTab;
            try
            {
                oldTab = tabControl.Tabs[scriptNumber - 1];
                TabData oldTabData = tabDatas.Find((t) => t.Guid == oldTab.Name);
                if (oldTabData != null)
                    oldTabData.Content = await ReadCurrentWebViewText();
            }
            catch { }
            tabControl.Tabs.Insert(tabControl.Tabs.Count - 1, newTab);
            await Task.Delay(1);
            tabControl.SelectedTab = newTab;
            currentTab = tabDatas.Last();
            PositionAddTabButton();


            SetCurrentWebViewText(tabContent);

            //MessageBox.Show(GlobalVariables.CurrentEditorTheme);
        }


        #endregion

        #region Events


        private async void ClearTabsMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Delay(1);
            if (!GlobalVariables.TabClosingPrompt)
            {
                tabDatas.Clear();
                ClearAllTabs();
                AddNewTab("Script 1");
            }
            var result = MessageBox.Show($"Are you sure you want to close all tabs?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                tabDatas.Clear();
                ClearAllTabs();
                AddNewTab("Script 1");
            }
        }
        private async void RenameTabMenuItem_Click(object sender, EventArgs e)
        {
            Manina.Windows.Forms.Tab selectedTab = tabControl.SelectedTab;
            TabData currentTabData = tabDatas.Find((t) => t.Guid == selectedTab.Name);
            if (selectedTab != null && selectedTab.Text != "+" && currentTabData != null)
            {
                currentForm.TopMost = false;
                string currentName = selectedTab.Text;
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new name for the tab (max 20 characters):", "Rename Tab", currentName);

                if (!string.IsNullOrEmpty(newName) && newName.Length <= 20 && newName != currentName)
                {
                    currentForm.TopMost = GlobalVariables.TopMostGlobal;
                    // Ensure the new name is unique
                    if (tabControl.Tabs.Any(tab => tab.Text == newName))
                    {
                        MessageBox.Show("A tab with this name already exists. Please choose a different name.", "Rename Tab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Update the tab name
                        selectedTab.Text = newName;
                        currentTabData.Name = newName;
                        SaveTabContent(currentTabData);
                        // Move the renamed tab to the top
                        tabControl.Tabs.Remove(selectedTab);
                        tabControl.Tabs.Insert(0, selectedTab);
                        tabControl.SelectedTab = selectedTab;
                    }
                }
                else if (newName.Length > 20)
                {
                    MessageBox.Show("The new tab name exceeds the 20-character limit. Please choose a shorter name.", "Rename Tab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TabControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tabControl.Tabs.Count; i++)
                {
                    var tab = tabControl.Tabs[i];
                    Rectangle r = tabControl.GetTabBounds(tab);
                    if (r.Contains(e.Location))
                    {
                        tabControl.SelectedIndex = i;
                        tabContextMenu.Show(tabControl, e.Location);
                        break;
                    }
                }
            }
        }
        private void TabControl_CloseTabButtonClick(object sender, CancelTabEventArgs e)
        {
            if (e.Tab.Text != "+" && tabControl.Tabs.Count > 2) // Prevent deletion if only one tab is left
            {
                if (GlobalVariables.TabClosingPrompt)
                {
                    var result = MessageBox.Show($"Are you sure you want to close {e.Tab.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result != DialogResult.Yes)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                // Ensure only the selected tab is removed
                DeleteTabFile(e.Tab.Name); // Delete the corresponding JSON file
                e.Cancel = true;
                tabControl.Tabs.Remove(e.Tab);
                int tabIndex = tabDatas.FindIndex((t) => t.Guid == e.Tab.Name);
                tabDatas.RemoveAt(tabIndex);
                PositionAddTabButton();
            }
            else
            {
                MessageBox.Show("You cannot delete the last tab!", "Error");
                e.Cancel = true; // Cancel the tab close action to prevent removing the last tab
            }
        }
        private async void TabControl_TabClick(object sender, TabMouseEventArgs e)
        {

            if (e.Tab.Text == "+")
            {
                AddNewTab();
                return;
            }


        }

        private async void TabControl_PageChanged(object sender, PageChangedEventArgs e)
        {
            // If the selected tab is the "Add Tab" button, switch to the newly created tab
            if (e.OldPage != null && e.OldPage.Text == "+")
            {
                await Task.Delay(1); // Add a slight delay
                var lastTab = tabControl.Tabs[tabControl.Tabs.Count - 2];
                tabControl.SelectedTab = lastTab;
                return;
            }
            TabData oldTabData = tabDatas.Find((t) => t.Guid == e.OldPage.Name);
            TabData newTabData = tabDatas.Find((t) => t.Guid == e.CurrentPage.Name);

            if (oldTabData == null || newTabData == null)
                return;
            oldTabData.Content = await ReadCurrentWebViewText();
            await Task.Delay(1);
            SetCurrentWebViewText(newTabData.Content);
        }
        private void TabControl_LayoutTabs(object sender, LayoutTabsEventArgs e)
        {
            // Custom layout logic for tabs, if needed
        }

        private async void SaveTabMenuItem_Click(object sender, EventArgs e)
        {
            Manina.Windows.Forms.Tab selectedTab = tabControl.SelectedTab;
            TabData tabData = tabDatas.Find((t) => t.Guid == selectedTab.Name);
            if (selectedTab != null && selectedTab.Text != "+" && tabData != null) 
            {
                SaveTabContent(tabData);
                MessageBox.Show("Tab content saved successfully!", "Save Tab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
