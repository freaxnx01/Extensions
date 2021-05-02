using System;
using System.IO;
using System.Net;
using System.ServiceModel.Syndication;
using System.Xml;
using HtmlAgilityPack;

namespace freaxnx01.Extensions
{
    public static class UriExtension
    {
        public static HtmlDocument GetHtmlDocument(this Uri uri)
        {
            return new HtmlWeb().Load(uri.AbsoluteUri);
        }
        
        public static SyndicationFeed GetRssFeed(this Uri uri)
        {
            using var reader = XmlReader.Create(uri.AbsoluteUri);
            return SyndicationFeed.Load(reader);
        }
        
        public static void DownloadAndShellExecute(this Uri uri)
        {
            Download(uri).LocalPath.ShellExecute();
        }

        public static DownloadedFile Download(this Uri uri)
        {
            using var wc = new WebClient();
            var downloadedFile = new DownloadedFile { RemoteFileName = Path.GetFileName(uri.AbsoluteUri) };
            var bytes = wc.DownloadData(uri.AbsoluteUri);
            if (wc.ResponseHeaders != null) downloadedFile.MimeType = wc.ResponseHeaders["content-type"];
            downloadedFile.LocalPath = Path.GetTempFileName();
            File.WriteAllBytes(downloadedFile.LocalPath, bytes);
            return downloadedFile;
        }
        
        public class DownloadedFile
        {
            public string MimeType { get; set; }
            public string LocalPath { get; set; }
            public string RemoteFileName { get; set; }
        }
    }
}