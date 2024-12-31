using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Synapse_Z
{
    internal class WebViewManager
    {
        // Helper method to escape special characters in the file content for JavaScript
        public static string EscapeJavaScriptString(string value)
        {
            if(value == null)
            {
                value = String.Empty;
            }
            return value.Replace("\\", "\\\\").Replace("`", "\\`").Replace("$", "\\$");
        }
        public static string EmbedJavaScriptContent(string html)
        {
            html = html.Replace("src=\"ace.js\"", $"src=\"data:text/javascript;base64,{WebViewManager.GetEmbeddedResourceBase64("Synapse_Z.Resources.ace.js")}\"");
            html = html.Replace("src=\"ext-language_tools.js\"", $"src=\"data:text/javascript;base64,{WebViewManager.GetEmbeddedResourceBase64("Synapse_Z.Resources.ext-language_tools.js")}\"");
            html = html.Replace("src=\"mode-lua.js\"", $"src=\"data:text/javascript;base64,{WebViewManager.GetEmbeddedResourceBase64("Synapse_Z.Resources.mode-lua.js")}\"");
            return html;
        }

        public static string GetEmbeddedResourceBase64(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException("Resource not found: " + resourceName);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string GetEmbeddedHtmlContent(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException("Resource not found: " + resourceName);
                }

                using (StreamReader reader = new StreamReader(stream))
                {
                    string html = reader.ReadToEnd();
                    html = WebViewManager.EmbedJavaScriptContent(html);
                    return html;
                }
            }
        }

    }
}
