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
    [PageType(Title = "VR Page", Route = "/vrpage")]
    public class VRPage : Page<VRPage>
    {
        public class JumbotronContent
        {
            [Field]
            public StringField Heading { get; set; }
            [Field]
            public TextField Content { get; set; }
            [Field]
            public TextField HeroImage { get; set; }
        }
        public class ArticleRegion
        {
            [Field]
            public StringField Heading { get; set; }
            [Field]
            public TextField Content { get; set; }
        }
        public class CaseRegion
        {
            [Field]
            public StringField Case1 { get; set; }
            [Field]
            public StringField Case1Img { get; set; }
            [Field]
            public StringField Case2 { get; set; }
            [Field]
            public StringField Case2Img { get; set; }
            [Field]
            public StringField Case3 { get; set; }
            [Field]
            public StringField Case3Img { get; set; }
        }

        [Region]
        public HtmlField Body { get; set; }
        [Region]
        public JumbotronContent HeroContent { get; set; }
        [Region]
        public ArticleRegion ArticleContent { get; set; }
        [Region]
        public CaseRegion Cases { get; set; }

    }
}
