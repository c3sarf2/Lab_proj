﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using IEEEAbstract;
//
//    var ieeeAbstract = IeeeAbstract.FromJson(jsonString);

namespace IEEEAbstract
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class IeeeAbstract
    {
        [JsonProperty("total_records")]
        public long TotalRecords { get; set; }

        [JsonProperty("total_searched")]
        public long TotalSearched { get; set; }

        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }
    }

    public partial class Article
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Ignore)]
        public string Isbn { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("authors")]
        public Authors Authors { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("article_number")]
        public long ArticleNumber { get; set; }

        [JsonProperty("pdf_url")]
        public Uri PdfUrl { get; set; }

        [JsonProperty("abstract_url")]
        public Uri AbstractUrl { get; set; }

        [JsonProperty("publication_title")]
        public string PublicationTitle { get; set; }

        [JsonProperty("publication_number")]
        public long PublicationNumber { get; set; }

        [JsonProperty("publication_year")]
        public long PublicationYear { get; set; }

        [JsonProperty("citing_paper_count")]
        public long CitingPaperCount { get; set; }

        [JsonProperty("citing_patent_count")]
        public long CitingPatentCount { get; set; }

        [JsonProperty("index_terms")]
        public IndexTerms IndexTerms { get; set; }

        [JsonProperty("doi", NullValueHandling = NullValueHandling.Ignore)]
        public string Doi { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public long? Volume { get; set; }

        [JsonProperty("conference_location", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceLocation { get; set; }

        [JsonProperty("conference_dates", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceDates { get; set; }

        [JsonProperty("is_number", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsNumber { get; set; }

        [JsonProperty("publication_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        [JsonProperty("start_page", NullValueHandling = NullValueHandling.Ignore)]
        public string StartPage { get; set; }

        [JsonProperty("end_page", NullValueHandling = NullValueHandling.Ignore)]
        public string EndPage { get; set; }

        [JsonProperty("html_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("issn", NullValueHandling = NullValueHandling.Ignore)]
        public string Issn { get; set; }

        [JsonProperty("partnum", NullValueHandling = NullValueHandling.Ignore)]
        public string Partnum { get; set; }
    }

    public partial class Authors
    {
        [JsonProperty("authors")]
        public List<Author> AuthorsAuthors { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("author_order")]
        public long AuthorOrder { get; set; }

        [JsonProperty("affiliation", NullValueHandling = NullValueHandling.Ignore)]
        public string Affiliation { get; set; }

        [JsonProperty("authorUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AuthorUrl { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }
    }

    public partial class IndexTerms
    {
        [JsonProperty("author_terms", NullValueHandling = NullValueHandling.Ignore)]
        public Terms AuthorTerms { get; set; }

        [JsonProperty("ieee_terms", NullValueHandling = NullValueHandling.Ignore)]
        public Terms IeeeTerms { get; set; }
    }

    public partial class Terms
    {
        [JsonProperty("terms")]
        public List<string> TermsTerms { get; set; }
    }

    public partial class IeeeAbstract
    {
        public static IeeeAbstract FromJson(string json) => JsonConvert.DeserializeObject<IeeeAbstract>(json, IEEEAbstract.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this IeeeAbstract self) => JsonConvert.SerializeObject(self, IEEEAbstract.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
