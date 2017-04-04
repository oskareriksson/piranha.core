/*
 * Copyright (c) 2017 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using Piranha.AttributeBuilder;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace CoreWeb.Models
{
    [PageType(Title = "About page", Route = "/aboutpage")]
    public class AboutPage : Page<AboutPage>
    {
        public class ComplexRegion
        {
            [Field]
            public StringField Title { get; set; }
            [Field]
            public StringField SubTitle { get; set; }
            [Field]
            public TextField Content { get; set; }
        }
        public class FormRegion
        {
            [Field]
            public StringField FirstLabel { get; set; }
            [Field]
            public StringField SecondLabel { get; set; }
            [Field]
            public StringField ThirdLabel { get; set; }
        }

        [Region]
        public HtmlField Body { get; set; }
        [Region]
        public TextField Intro { get; set; }
        [Region]
        public ComplexRegion MainContent { get; set; }
        [Region]
        public FormRegion CustomForm { get; set; }

    }
}
