// -----------------------------------------------------------------------
//  <copyright file="PageFeature.cs" company="Loose Coupling Limited">
//      Copyright (c) Loose Coupling. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------

using System;
using Loose.Net;
using Loose.Tests;
using Loose.Tests.Properties;
using Machine.Specifications;
using Rhino.Mocks;

namespace Loose.Model.Tests
{
    [Subject(typeof(Page), "retreiving content")]
    public class when_i_have_a_page_with_a_valid_url : page_context
    {
        Establish context = () =>
            {
                Uri = new Uri("http://www.goldmansachs.com/a/data/jobs/search.html");
                WebClient = MockRepository.GenerateMock<IWebClient>();
                WebClient.Expect(item => item.DownloadPage(Uri)).Return(ResourceList.GoldmanSachs_Index_Page);
                Page = new Page(WebClient) { Uri = Uri };
            };

        Because of = () =>
            {
                Page.Refresh();                 
            };

        It should_call_the_download_method_of_the_web_client = () =>
            {
                WebClient.AssertWasCalled(item => item.DownloadPage(Uri));
            };

        It should_be_able_to_retrieve_the_html_for_that_page = () =>
            {
                Page.Html.ShouldNotBeNull();
            };
    }


    #region contexts
    public class page_context : base_context
    {
        protected static Page Page;

        protected static IWebClient WebClient;

        protected static Uri Uri;

        public static new void ResetTestState()
        {
            base_context.ResetTestState();
            Page = null;
            Uri = null;
            WebClient = null;
        }
    }
    #endregion
}