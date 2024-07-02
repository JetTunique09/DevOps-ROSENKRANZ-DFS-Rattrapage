using Xunit;
using EvaluationSampleCode;
using System;
using System.Collections.Generic;

namespace EvaluationSampleCodeTests
{
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper htmlFormatHelper;

        public HtmlFormatHelperTests()
        {
            htmlFormatHelper = new HtmlFormatHelper();
        }

        // tests scénario : format bold du contenu valide
        [Fact]
        public void GetStrongFormat_ValidContent_ReturnsStrongFormattedString()
        {
            string content = "Hello, World!";
            string expected = "<strong>Hello, World!</strong>";
            string result = htmlFormatHelper.GetStrongFormat(content);
            Assert.Equal(expected, result);
        }

        // tests scénario : format italique du contenu valide
        [Fact]
        public void GetItalicFormat_ValidContent_ReturnsItalicFormattedString()
        {
            string content = "Hello, World!";
            string expected = "<i>Hello, World!</i>";
            string result = htmlFormatHelper.GetItalicFormat(content);
            Assert.Equal(expected, result);
        }

        // tests scénario : format liste des contenus valides
        [Fact]
        public void GetFormattedListElements_ValidContents_ReturnsFormattedList()
        {
            List<string> contents = new List<string> { "Item1", "Item2", "Item3" };
            string expected = "<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>";
            string result = htmlFormatHelper.GetFormattedListElements(contents);
            Assert.Equal(expected, result);
        }

        // tests scénario : format liste vide
        [Fact]
        public void GetFormattedListElements_EmptyList_ReturnsEmptyList()
        {
            List<string> contents = new List<string>();
            string expected = "<ul></ul>";
            string result = htmlFormatHelper.GetFormattedListElements(contents);
            Assert.Equal(expected, result);
        }

    }
}
