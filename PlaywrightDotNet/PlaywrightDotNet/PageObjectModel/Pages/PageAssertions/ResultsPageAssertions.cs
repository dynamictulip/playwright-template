﻿using System.Text.RegularExpressions;

namespace PlaywrightDotNet.PageObjectModel.Pages.PageAssertions;

public class ResultsPageAssertions
{
    private ResultsPage ResultsPage { get; }

    public ResultsPageAssertions(ResultsPage resultsPage)
    {
        ResultsPage = resultsPage;
    }

    public async Task ToBeOnResultsPageAsync()
    {
        await Assertions.Expect(ResultsPage.Page).ToHaveURLAsync(new Regex(".+/form-results"));
    }
}