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
        }
        public class ArticleRegion
        {
            [Field]
            public StringField Heading { get; set; }
            [Field]
            public TextField Content { get; set; }
        }

        [Region]
        public HtmlField Body { get; set; }
        [Region]
        public JumbotronContent HeroContent { get; set; }
        [Region]
        public ArticleRegion ArticleContent { get; set; }

    }
}