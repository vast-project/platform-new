using System.Net;
using static System.Net.WebRequestMethods;

namespace Platform.Data
{
    public class MockRepository : IDataRepository
    {
        List<Article> articles = new List<Article>
                {
                    new Article()
                    {
                        Id = 2,
                        Slug = "what-are-values",
                        Title = "What are Values?",
                        Description = "From everyday life  discussions to scientific and philosophical accounts the term ‘values’ has various meanings.<br>This page briefly explains some of those meanings and their origins.",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() {"values", "human", "dignity", "freedom", "democracy", "rule", "law", "rights"},
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content="<p><span>From everyday life \r\ndiscussions to scientific and philosophical accounts the term <i>‘values’</i>\r\nhas various meanings. </span></p>\r\n<p><span>Here are some\r\nlexical definitions of values: </span></p>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"624\">\r\n<tr>\r\n<td valign=\"top\">\r\n<p><i><span>“…\r\n  2. a moral, social, or aesthetic principle accepted by an individual or\r\n  society as a guide to what is good, desirable, or important.</span></i></p>\r\n<p><i><span>3.\r\n  the worth, usefulness, or importance attached to something.”</span></i></p>\r\n<p align=\"right\"><span>APA Dictionary (</span><span><a href=\"https://dictionary.apa.org/value\"><span>Accessed on: 01/08/2023</span></a><span>)</span></span></p>\r\n</td>\r\n</tr>\r\n</table>\r\n<p><span> </span></p>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"624\">\r\n<tr>\r\n<td valign=\"top\">\r\n<p><i><span>“…strongly\r\n  held beliefs about what is important, valuable or appropriate ”</span></i></p>\r\n<p align=\"right\"><span>Britannica Dictionary (</span><span><a href=\"https://www.britannica.com/dictionary/value#:~:text=Britannica%20Dictionary%20definition%20of%20VALUE,%5Bnoncount%5D\"><span>Accessed on: 02/08/2023</span></a><span>)</span></span></p>\r\n</td>\r\n</tr>\r\n</table>\r\n<p><span> </span></p>\r\n<p><b><span>EU Values</span></b></p>\r\n<p><span>The European\r\nUnion is founded on the following </span><span><a href=\"https://european-union.europa.eu/principles-countries-history/principles-and-values/aims-and-values_en\"><span>values</span></a><span>:</span></span></p>"
                            },
                            new Section()
                            {
                                Type = "euvalues",
                                Content = ""
                            },
                            new Section()
                            {
                                Type="text",
                                Content="<p><b><span>Sociological\r\nand psychological understanding of values</span></b></p>\r\n<p><span>According to\r\nSchwartz [1, p. 21], values are: </span></p>\r\n<p><span>“<b><i>desirable\r\ntrans-situational goals, varying in importance, that serve as guiding\r\nprinciples in the life of a person or other social entity.</i></b>” </span></p>\r\n<p><span>Schwartz specifies 7\r\ncharacteristics of values [2]: </span></p>\r\n<p><span>1.<span>     </span></span><span>Values\r\nare beliefs about the importance of desirable goals.</span></p>\r\n<p><span>2.<span>     </span></span><span>When\r\nactivated, values elicit emotion.</span></p>\r\n<p><span>3.<span>     </span></span><span>Values\r\nare basic goals that apply across specific situations.</span></p>\r\n<p><span>4.<span>     </span></span><span>Values\r\nconsciously or unconsciously motivate behavior, perception, and attitudes.</span></p>\r\n<p><span>5.<span>     </span></span><span>Value\r\neffects occur through a process of trade-offs among the relevant values.</span></p>\r\n<p><span>6.<span>     </span></span><span>Values\r\nserve as standards for evaluating actions, people, and events.</span></p>\r\n<p><span>7.<span>    \r\n</span></span><span>Values are ordered by importance in a relatively enduring\r\nhierarchical system.</span></p>\r\n<p><span> </span></p>\r\n<p><span>According to\r\nSchwartz’s refined theory of values [3], which builds on his earlier theory of\r\n10 basic personal values [4], there are 19 basic personal values. These values\r\ncan be ordered in four universal value dimensions—Self-enhancement vs.\r\nSelf-Transcendence, and Openness to Change vs. Conservation. The following\r\ntable presents the four higher order values, the 19 more narrowly defined\r\nvalues along with their definitions (as adapted from [2]). </span></p>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">\r\n<style>tr:nth-child(even) {background-color: #f2f2f2;}</style>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><span>Four\r\n  higher order values</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>19\r\n  values</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Definitions</span></p>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td rowspan=\"6\" valign=\"top\">\r\n<p><span>Self-transcendence </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><b><span>Benevolence</span></b><span>-</span></p>\r\n<p><span>Dependability </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Being a reliable and\r\n  trustworthy member of the in-group</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Benevolence</span></b><span>-</span></p>\r\n<p><span>Caring</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Devotion to the welfare of\r\n  in-group members </span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Universalism</span></b><span>-</span></p>\r\n<p><span>Tolerance </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Acceptance and understanding\r\n  of those who are different from oneself </span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Universalism</span></b><span>-</span></p>\r\n<p><span>Concern </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Commitment to equality,\r\n  justice, and protection for all people</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Universalism</span></b><span>-</span></p>\r\n<p><span>Nature </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Preservation of the natural\r\n  environment </span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td rowspan=\"2\" valign=\"top\">\r\n<p><b><span>Humility</span></b></p>\r\n</td>\r\n<td rowspan=\"2\" valign=\"top\">\r\n<p><span>Recognizing one’s\r\n  insignificance in the larger scheme of things</span></p>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td rowspan=\"7\" valign=\"top\">\r\n<p><span> </span></p>\r\n<p><span>Conservation</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Conformity</span></b><span>-</span></p>\r\n<p><span>Interpersonal</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Avoidance\r\n  of upsetting or harming other people </span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Conformity</span></b><span>-</span></p>\r\n<p><span>Rules</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Compliance\r\n  with rules, laws, and formal obligations</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Tradition</span></b></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Maintaining\r\n  and preserving cultural, family, or religious traditions </span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Security</span></b><span>-</span></p>\r\n<p><span>Societal</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Safety\r\n  and stability in the wider society </span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Security</span></b><span>-</span></p>\r\n<p><span>Personal</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Safety\r\n  in one’s immediate environment</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td rowspan=\"3\" valign=\"top\">\r\n<p><span> </span></p>\r\n<p><span>Face</span></p>\r\n</td>\r\n<td rowspan=\"3\" valign=\"top\">\r\n<p><span>Security\r\n  and power through maintaining one’s public image and avoiding humiliation</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td rowspan=\"6\" valign=\"top\">\r\n<p><span> </span></p>\r\n<p><span>Self-\r\n  enhancement</span></p>\r\n</td>\r\n\r\n</tr>\r\n<tr>\r\n<td></td>\r\n<td width=\"0\"><p> </p></td>\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Power</span></b><span>-</span></p>\r\n<p><span>Resources</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Power through control of\r\n  material and social resources </span></p>\r\n</td>\r\n<td></td>\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Power</span></b><span>-</span></p>\r\n<p><span>Dominance </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Power through exercising\r\n  control over people </span></p>\r\n</td>\r\n<td></td>\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Achievement</span></b><span> </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Personal success through\r\n  demonstrating competence according to social standards</span></p>\r\n</td>\r\n<td></td>\r\n\r\n</tr>\r\n<tr>\r\n<td rowspan=\"3\" valign=\"top\">\r\n<p><b><span>Hedonism</span></b></p>\r\n</td>\r\n<td rowspan=\"3\" valign=\"top\">\r\n<p><span>Pleasure and sensuous gratification\r\n  for oneself </span></p>\r\n</td>\r\n<td></td>\r\n\r\n</tr>\r\n<tr>\r\n<td rowspan=\"5\" valign=\"top\">\r\n<p><span> </span></p>\r\n<p><span>Openness\r\n  to change</span></p>\r\n</td>\r\n<td></td>\r\n\r\n</tr>\r\n<tr>\r\n<td></td>\r\n<td width=\"0\"><p> </p></td>\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Stimulation</span></b><span> </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>Excitement, novelty, and\r\n  challenge in life </span></p>\r\n</td>\r\n<td></td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Self-Direction</span></b><span>-Action</span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span> The freedom to determine\r\n  one’s own actions</span></p>\r\n</td>\r\n<td></td>\r\n\r\n</tr>\r\n<tr>\r\n<td valign=\"top\">\r\n<p><b><span>Self-Direction</span></b><span>-Thought\r\n  - </span></p>\r\n</td>\r\n<td valign=\"top\">\r\n<p><span>The freedom to cultivate\r\n  one’s own ideas and abilities</span></p>\r\n</td>\r\n<td></td>\r\n\r\n</tr>\r\n</table>\r\n<p><span> </span></p>\r\n<p><span>REFERENCES</span></p>\r\n<p><span> </span></p>\r\n<p><span>[1] Schwartz, S.H., 1994. Are\r\nthere universal aspects in the content and structure of values. Journal of\r\nsocial issues, 50(4), pp.19-45.</span></p>\r\n<p><span>[2] Schwartz, S.H. and\r\nCieciuch, J., 2022. Measuring the refined theory of individual values in 49\r\ncultural groups: psychometrics of the revised portrait value questionnaire.\r\nAssessment, 29(5), pp.1005-1019.</span></p>\r\n<p><span>[3] Schwartz, S.H., Cieciuch,\r\nJ., Vecchione, M., Davidov, E., Fischer, R., Beierlein, C., Ramos, A.,\r\nVerkasalo, M., Lönnqvist, J.E., Demirutku, K. and Dirilen-Gumus, O., 2012.\r\nRefining the theory of basic individual values. Journal of personality and\r\nsocial psychology, 103(4), p.663.</span></p>\r\n<p><span>[4] Schwartz, S.H., 1992.\r\nUniversals in the content and structure of values: Theory and empirical tests\r\nin 20 countries, 1–65. Teoksessa M. Zanna (toim.) Advances in experimental\r\nsocial psychology, vol. 25.</span></p>\r\n<p><span> </span></p>"
                            },

                        }
                    },
                    new Article()
                    {
                        Id = 3,
                        Slug = "vast-map",
                        Title = "Map of project activities",
                        Description = "A map showing where the most significant project activities are taking place",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "map" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "This map shows the locations of the most significant project activities. You can also select an activity from the list and the map will display its location."
                            },
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://visualize.vast-project.eu/superset/dashboard/1df540e9-17b4-43a0-8481-530fb86643d4/?standalone=3&filter=2"
                             },

                        }
                    },
                    new Article()
                    {
                        Id = 4,
                        Slug = "about",
                        Title = "About the VAST project",
                        Description = "A brief description of the VAST project",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "about" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>VAST aims to study the transformation of moral values across space and time.</p>\r\n<p>An emphasis will be placed in those core European values considered fundamental for the formation of sustainable communities and enabling citizens to live well together, such as: freedom, democracy, equality, tolerance, dialogue, human dignity, the rule of law.</p>\r\n<p>In order to examine the past of values we will analyse narratives expressed in natural language, trace and inter-link the values emerging. The narratives that will be analysed are relevant to the Arts (ancient Greek tragedies), Science (17th Century Scientific Revolution texts) and Folklore (fairytales). The narratives were chosen as to represent different places and significant moments in European history.</p>\r\n<p>In order to examine the present of values we will collect and digitise the experiences of those in charge of communicating values in the present, especially through arts (focusing on theatre), folklore preservation (focusing on folktale storytelling), science (focusing on how science is communicated through museums) and education (focusing on museum educational programs). Finally, audiences will be exposed to moral values, through theatrical plays, museum visits and educational programs, in order to collect (and digitise) their appropriations of these values.</p>"
                            },
                            new Section()
                            {
                                Type = "text",
                                Content = "<div class=\"team\" data-team-id=\"team-3195\" data-initial-group=\"1\">\r\n    <div class=\"team-header\">\r\n        <div class=\"team-nav\">\r\n            <i class=\"fa fa-bars\" aria-hidden=\"true\"></i>\r\n            <div class=\"team-nav-item selected\" data-group=\"1\">Partnership</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"team-grid\">\r\n        <div class=\"team-grid-sizer\"></div>\r\n\r\n        <!-- NCSR Demokritos -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/demokritos.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>NCSR Demokritos</h4>\r\n                </div>\r\n                <a href=\"https://www.iit.demokritos.gr/\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- University of Milan -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/uml.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>University of Milan</h4>\r\n                </div>\r\n                <a href=\"https://www.unimi.it/en\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- National and Kapodistrian University of Athens -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/ekpa.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>National and Kapodistrian University of Athens</h4>\r\n                </div>\r\n                <a href=\"https://en.uoa.gr/\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Nova University of Lisbon -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/novafsc.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>Nova University of Lisbon</h4>\r\n                </div>\r\n                <a href=\"https://www.fcsh.unl.pt/en\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Fairy Tale Museum -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/fairy_tale_museum.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>Fairy Tale Museum</h4>\r\n                </div>\r\n                <a href=\"https://www.fairytalemuseum.org.cy/en/\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Semantika -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/semantika_logo.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>Semantika</h4>\r\n                </div>\r\n                <a href=\"https://semantika.eu/en-us/\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Museo Galileo Istituto e Museo di Storia della Scienza -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/themes/rt_akuatik/custom/images/museo_galileo.jpg');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>Museo Galileo Istituto e Museo di Storia della Scienza</h4>\r\n                </div>\r\n                <a href=\"https://www.museogalileo.it/en\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Athens Epidaurus Festival -->\r\n        <div class=\"team-grid-item\" data-groups='[\"1\"]'>\r\n            <div class=\"grid-item-wrapper\">\r\n                <div class=\"grid-item-image\">\r\n                    <div class=\"grid-item-blob\" style=\"background-image: url('https://www.vast-project.eu/wp-content/uploads/2021/04/AEF_new_logo.png');\"></div>\r\n                </div>\r\n                <div class=\"content-wrap\">\r\n                    <h4>Athens Epidaurus Festival</h4>\r\n                </div>\r\n                <a href=\"http://aefestival.gr/?lang=en\" target=\"_blank\" class=\"team-link-overlay\"></a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"
                            }
                        }
                    },
                    /*new Article()
                    {
                        Id = 5,
                        Slug = "video",
                        Title = "Video Teasers & Tutorials",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>Below you can find a short set of videos to help you understand what the VAST project does and how it is relevant to you.<p>"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/SqK7SHMq8mI?si=uAPETsH0gj2AZGhl"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/YCqIGjWZ3lw?si=aeWngbVAm12btR5l"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/86gRmiVYhKQ?si=3aE8V6Lmt-BTnCHg"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/C1FVm7IRNjA?si=AMFeCXL4jWv-h1G1"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/HpCKDMjJz4k?si=pux3TTD4x6SDEfp0"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/4UD7NAjxHgs?si=HuK9JkwcLTpMBuBw"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/0RJSwhxRQvY?si=ybBFrQraM9qF0EWU"
                            },
                            new Section()
                            {
                                Type="yt",
                                Url = "https://www.youtube.com/embed/5Frki5HKgdA?si=7KK2jNGF8jHwCTgH"
                            }
                        }
                    },*/
                    new Article()
                    {
                        Id = 6,
                        Slug = "edu-activity-cyprus",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1024&ext=png&k=",
                        Title = "Conducting Effective Co-creation Activities",
                        Description = "The booklet is addressed to anyone who wants to organise and implement an educational activity or a workshop for raising awareness, teaching, or enhancing skills, and is available in the link Conducting Effective Co-creation Activities/Workshops.",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Category = "Methodologies",
                        TargetGroup = "",
                        Tags = new List<string>() { "resources" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>Using the experience, methodologies and tools developed through research in the VAST project, the partner Fairy Tale Museum in Cyprus created a handbook which assists in Conducting Effective Co-creation Activities/Workshops.</p>\r\n<p>The booklet is addressed to anyone who wants to organise and implement an educational activity or a workshop for raising awareness, teaching, or enhancing skills, and is available in the link Conducting Effective Co-creation Activities/Workshops.</p>\r\n<p>Through this initiative, VAST offers a step-by-step guide on how to plan, design, and implement high-quality, integrated and inclusive educational and co-creation activities or workshops adjusted to meet the needs of specific audiences and capture their experience.  Specifically, the guidelines include all the steps necessary to be followed prior to the activity (planning & preparation), during the activity (implementation), and after the activity (evaluation).</p>"
                            },
                            new Section()
                            {
                                Type="pdf",
                                Url = "https://www.vast-project.eu/wp-content/uploads/2023/01/VAST_Booklet_Conducting-Effective-Co-creation-Activities-and-Workshops.pdf",
                            }
                        }
                    },
                    /*new Article()
                    {
                        Id = 7,
                        Slug = "edu-handbook-hogi",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1025&ext=png&k=",
                        Title = "Handbook of Activities",
                        Description = "This is the manual title: \"Values Travel: Guide to Educational Activities.\" This manual contains three proposed educational activities for young people, which have been implemented in practice in collaboration with schools and museums.",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Category = "Methodologies",
                        TargetGroup = "",
                        Tags = new List<string>() { "resources" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>Within the framework of the VAST project, a manual titled \"Values Travel: Guide to Educational Activities\" has been designed. This manual contains three proposed educational activities for young people, which have been implemented in practice in collaboration with schools and museums. These educational activities are based on the principles of experiential learning and collaborative teaching approaches, promoting active participation and action of young people through dialogue and practice. Following the principles of the Council of Europe regarding democratic citizenship and human rights education, the educational process should focus not only on knowledge transfer but also on promoting values, attitudes, and behaviors that sensitize and motivate young people for further reflection. The manual aims to present and provide suggested educational content to members of the educational and school communities who wish to work in this direction.</p>"
                            },
                            new Section()
                            {
                                Type="pdf",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=37&ext=pdf&k=",
                            }
                        }
                    },*/
                    new Article()
                    {
                        Id = 8,
                        Slug = "annotation-tool",
                        Title = "Multimodal Annotation Tool",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1046&ext=png&k=",
                        Category = "Semantic Analysis",
                        Description = "Methodologies and education material on how to design and implement surveys, activities and digital campaigns",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "services" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>VAST’s semantic annotation platform allows the collaborative, multimodal, analysis and annotation of artefacts (primary with values, but not limited to values), for professionals like scholars analysing narratives, or museum curators who want to extend the available metadata on their collections.<p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1046&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://annotation.vast-project.eu/"
                            },
                            new Section()
                            {
                                Type = "gh-link",
                                Url = "https://github.com/vast-project/ellogon-annotation-tool"
                            }
                        }
                    },
                    new Article()
                    {
                        Id = 9,
                        Slug = "ontology-tool",
                        Title = "Ontology Design Tool",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?ref=1044&ext=png&k=",
                        Category = "Value Exploration",
                        Description = "The VAST knowledge base of digitised experiences and all analysed and annotated artefacts",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "services" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>The VAST Ontology Design Tool can help policy makers and scholars navigate corpora of annotated texts and link them to values through simple statements.\r\n<p>\r\n"
                            },
                            new Section()
                            {
                                Type = "image",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1044&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://ontology.vast-project.eu/"
                            }
                        }
                    },
                    new Article()
                    {
                        Id = 10,
                        Slug = "survey-tool",
                        Title = "Surveys",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1043&ext=png&k=",
                        Description = "Create digital surveys…",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "services" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>The Survey Tool (supported by WPForms https://wpforms.com/docs/) helps researchers prepare digital surveys that can then be analysed or ingested into the VAST knowledge base. A mobile application can help people provide access to the created surveys.<p>\r\n"
                            },
                            new Section()
                            {
                                Type = "image",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1043&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://platform.vast-project.eu/wp-admin"
                            },
                            new Section()
                            {
                                Type = "gh-link",
                                Url = "https://github.com/vast-project/vast-survey-tool"
                            }
                        }
                    },
                    new Article()
                    {
                        Id = 101,
                        Slug = "rule-of-law",
                        Title = "Exploring the Rule of Law",
                        Description = "An activity that allows you to explore the rule of law and practical challenges encountered when trying to implement it",
                        Author = "VAST Project",
                        Date = "16th of September 2023",
                        Tags = new List<string>() { "activity", "dialogue", "democracy", "empathy", "female speech", "free thinking", "freedom of expression", "human dignitiy", "human rights", "justice", "law of god", "loyalty", "piety", "punishment", "reason", "right vs wrong", "rule of law", "solidarity", "truth", "violence vs kindness" },
                        Sections = new List<Section>()
                        {
                            /*new Section()
                            {
                                Type="text",
                                Content = "<p>Use your mouse to select. If you enter full-screen mode, you can press Esc to return. You can change the language at the bottom of the page. There is a progress bar at the top of the page.</p>"
                            },*/
                            new Section()
                            {
                                Type="iframe-internal",
                                Url = "/the-trial-of-antigone/"
                            }
                        }
                    },
                    new Article
                    {
                        Id = 201,
                        Slug = "vast-project-participates-in-icom-activities",
                        Category = "Educational Event",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1040&ext=png&k=",
                        Title = "VAST project participates in activities of the International Council of Museums (ICOM)",
                        Description = "<p>In celebration of the International Museum Day 2023 on May 18, VAST project collaborated with the national Greek project ‘House of Greek Ideas’ in an educational event exploring the theme of values, particularly through the lens of Sophocles’ Antigone.</p>",
                        Author = "VAST Project",
                        Date = "19th of May 2023",
                        Tags = new List<string>() {"success", "education", "museums", "interactive"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type="iframe-internal",
                                Url = "https://www.vast-project.eu/vast-project-participates-in-international-council-of-museums-icom-activities/"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 202,
                        Slug = "vast-educational-activity-at-noesis-science-museum",
                        Category = "Educational Activity",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1039&ext=png&k=",
                        Title = "VAST educational activity at NOESIS Science Museum, GR",
                        Description = "<p>VAST Team conducted an educational activity at NOESIS Science Center and Technology Museum on 28 April 2023, guiding students from High School ‘Apostolos Pavlos’ in exploring values and decision-making through interactive exercises and discussions based on ‘Antigone’ tragedy.</p>",
                        Author = "VAST Project",
                        Date = "3rd of May 2023",
                        Tags = new List<string>() {"success", "education", "science", "interactive"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type="iframe-internal",
                                Url = "https://www.vast-project.eu/vast-project-activity-in-noesis-museum/"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 203,
                        Slug = "vast-educational-activity-in-high-school-gerakas-gr",
                        Category = "Educational Activity",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1038&ext=png&k=",
                        Title = "Educational activity in high school in Gerakas, GR",
                        Description = "<p>On 10 May 2023, VAST project organized an educational activity at the 2nd High School of Gerakas, Athens, exploring moral dilemmas through ancient tragedy heroes. The interactive session encouraged students to reflect on values and their significance in decision-making.</p>",
                        Author = "VAST Project",
                        Date = "10th of May 2023",
                        Tags = new List<string>() {"success", "education", "ancient drama", "interactive"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type="iframe-internal",
                                Url = "https://www.vast-project.eu/vast-educational-activity-in-high-school-gerakas-gr/"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 204,
                        Slug = "partner-museo-galileo-organises-theatrical-performance-florence",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1037&ext=png&k=",
                        Category = "Theatrical Performance",
                        Title = "Partner Museo Galileo organises a theatrical performance in Florence",
                        Description = "<p>Museo Galileo organized a theatrical performance on 22 February 2023, reviving the era of the 17th-century scientific revolution through characters Galileo Galilei and Amerigo Vespucci, prompting audience reflection on the significance of their discoveries.</p>",
                        Author = "VAST Project",
                        Date = "24th of February 2023",
                        Tags = new List<string>() {"success", "theatre", "scientific revolution", "interactive"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type="iframe-internal",
                                Url = "https://www.vast-project.eu/partner-museo-galileo-organises-theatrical-performance-florence/"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 205,
                        Slug = "ftm-organises-interactive-narration-snow-white-seven-dwarfs",
                        Title = "Interactive narration of Snow White & the Seven Dwarfs",
                        Description = "<p>On 3 December 2022, VAST partner Fairy Tale Museum in Nicosia hosted an interactive narration of Snow White and the Seven Dwarfs for children aged six to nine, aiming to explore children's understanding of values conveyed through fairy tales and their reflection in daily lives.</p>",
                        Author = "VAST Project",
                        Date = "5th of December 2022",
                        Tags = new List<string>() {"fairy tales", "interactive", "education"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type="iframe-internal",
                                Url = "https://www.vast-project.eu/ftm-revives-through-an-interactive-narration-the-fairy-tale-snow-white-and-the-seven-dwarfs/"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 401,
                        Slug = "vast-digitisation-application",
                        Title = "VAST Digitisation Application",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1041&ext=png&k=",
                        Category = "Digitisation Wizard",
                        Description = "<p>A simple wizard to digitise activities and contribute to VAST Knowledge Graph</p>",
                        Author = "VAST Project",
                        Date = "17th of October 2023",
                        Tags = new List<string>() {"services", "digitisation", "knowledge graph", "ontology"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>The VAST digitisation application serves as a simple wizard, enabling authenticated users to contribute data to the VAST Knowledge Graph, utilizing the VAST Ontology.\r\n</p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1041&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://activities-backend.vast-project.eu/"
                            },
                            new Section()
                            {
                            Type = "gh-link",
                            Url = "https://github.com/vast-project/activities-visualisation/tree/main/activities-backend"
                        }
                        },
                    },

                    new Article
                    {
                        Id = 402,
                        Slug = "imss-activity-mind-map-creation",
                        Title = "Digital Companion for IMSS Activity",
                        Category = "Digitisation App",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1047&ext=png&k=",
                        Description = "<p>This application accompanies the IMSS activity, facilitating the creation of mind maps via an adaptable web interface.</p>",
                        Author = "VAST Project",
                        Date = "17th of October 2023",
                        Tags = new List<string>() {"services", "mind maps", "digital companion", "web interface"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>This application accompanies the IMSS activity, facilitating the creation of mind maps via an adaptable web interface.</p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1047&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://imss-activity.vast-project.eu/"
                            },
                            new Section()
                            {
                                Type = "gh-link",
                                Url = "https://github.com/vast-project/activities-visualisation/tree/main/imss-mindmap"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 403,
                        Slug = "ncsr-values-workshop",
                        Title = "Pocket Values",
                        Category = "Digitisation App",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1045&ext=png&k=",
                        Description = "<p>Engage in a two-step activity with NCSR, analyzing values in Karel Capek's ‘Rossum’s Universal Robots’, and later ranking these values based on personal significance.</p>",
                        Author = "VAST Project",
                        Date = "17th of October 2023",
                        Tags = new List<string>() {"services", "values", "Karel Capek", "NCSR"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>This is a customizable web-app that collects peoples’ perception on values with respect to a specific Cultural Heritage (CH) artifact. It implements three steps that can be integrated in educational activities:</p><ol><li>Description of the participant through a WP-forms questionnaire.</li><li>Annotation of narrative of choice.</li><li>Building a hierarchy of values based on the concepts annotated.</li></ol><p>The integrated text in the provided example is from Karel Capek's ‘Rossum’s Universal Robots’.</p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1045&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://ncsr-activity.vast-project.eu/"
                            },
                            new Section()
                            {
                                Type = "gh-link",
                                Url = "https://github.com/vast-project/activities-visualisation/tree/main/values-workshop"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 404,
                        Slug = "ftm-values-in-fairy-tales",
                        Title = "Values in Fairy Tales: An FTM Activity",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1042&ext=png&k=",
                        Category = "Digitisation App",
                        Description = "<p>Explore values through the realm of fairy tales with FTM. Delve into how these narratives and their inherent values influence teenagers and society at large. </p>",
                        Author = "VAST Project",
                        Date = "17th of October 2023",
                        Tags = new List<string>() {"services", "fairy tales", "values", "FTM"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>Explore values through the realm of fairy tales with FTM. Delve into how these narratives and their inherent values influence teenagers and society at large.</p>"
                            },
                            new Section()
                            { 
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1042&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://ftm-activity.vast-project.eu/"
                            },
                            new Section()
                            {
                                Type = "gh-link",
                                Url = "https://github.com/vast-project/activities-visualisation/tree/main/ftm-project"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 405,
                        Slug = "interactive-red-riding-hood",
                        Title = "Interactive Red Riding Hood",
                        Category = "Play",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1049&ext=png&k=",
                        TargetGroup = "Ages 5-100",
                        Description = "<p>Embark on an interactive journey through the tale of Little Red Riding Hood. Navigate through the story, uncovering values through interactive questions along the way.</p>",
                        Author = "VAST Project",
                        Date = "17th of October 2023",
                        Tags = new List<string>() {"games", "interactive", "Little Red Riding Hood", "values", "trust"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>Embark on an interactive journey through the tale of Little Red Riding Hood. Navigate through the story, uncovering values through interactive questions along the way.</p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1049&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://redcapp.islab.di.unimi.it/"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 406,
                        Slug = "write-dialogues-canas",
                        Title = "Write imaginary dialogues with Canvas Conversation Tales",
                        Category = "Play",
                        SmallImage = "https://dam.vast-project.eu/filestore/2/1/2/1_85306e7b90891c0/1212scr_9eb66c8e577f969.jpg?v=1708367248",
                        TargetGroup = "Ages 20-100",
                        Description = "Canvas Conversation Tales is a web application to create stories in the form of imaginary dialogues based on the visual content of a selected artwork. Users can compose their own conversations or continue someone else’s story, with the opportunity to contribute and vote on imaginary line exchanges.",
                        Author = "VAST Project",
                        Date = "19th of February 2024",
                        Tags = new List<string>() {"games", "interactive", "values"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>Canvas Conversation Tales is a web application to create stories in the form of imaginary dialogues based on the visual content of a selected artwork. Users can compose their own conversations or continue someone else’s story, with the opportunity to contribute and vote on imaginary line exchanges.</p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?ref=1212&size=hpr&ext=jpg&k=&alternative=-1&iaccept=off&usage=-1&usagecomment=&email="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://cct.islab.di.unimi.it"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 411,
                        Slug = "interactive-antigone",
                        Title = "Trial of Antigone",
                        Category = "Play",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1050&ext=png&k=",
                        TargetGroup = "Ages 15-100",
                        Description = "<p>Embark on an interactive journey through the tale of Little Red Riding Hood. Navigate through the story, uncovering values through interactive questions along the way.</p>",
                        Author = "VAST Project",
                        Date = "17th of October 2023",
                        Tags = new List<string>() {"games", "interactive", "Antigone", "values"},
                        Sections = new List<Section>
                        {
                            new Section
                            {
                                Type = "text",
                                Content = "<p>This interactive application allows you to take part in Sophocles’ renowned ancient Greek tragedy “Antigone” and ponder on a moral dilemma: What should we do when the city’s law conflicts with what we consider morally just? </p>"
                            },
                            new Section()
                            {
                                Type = "image",
                                Content = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1050&ext=png&k="
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://aylon.vast-project.eu/antigone/"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 1001,
                        Slug = "statistics-overview",
                        Title = "VAST Overview Statistics",
                        Description = "<p>The main statistics of the VAST project</p>",
                        Author = "VAST Project",
                        Date = "26th of October 2023",
                        Tags = new List<string>() {"stats"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://visualize.vast-project.eu/superset/dashboard/2bb44d4c-163c-4562-83ff-0d3ea1bb670b/?standalone=true"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 1002,
                        Slug = "statistics-past",
                        Title = "VAST Past of Values Statistics",
                        Description = "<p>The past of values statistics of the VAST project</p>",
                        Author = "VAST Project",
                        Date = "26th of October 2023",
                        Tags = new List<string>() {"stats"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://visualize.vast-project.eu/superset/dashboard/7a0ac959-ed9b-47b6-b604-8aa85ab0342a/?standalone=true"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 1003,
                        Slug = "statistics-present",
                        Title = "VAST Present of Values Statistics",
                        Description = "<p>The present of values statistics of the VAST project</p>",
                        Author = "VAST Project",
                        Date = "26th of October 2023",
                        Tags = new List<string>() {"stats"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://visualize.vast-project.eu/superset/dashboard/2fd8e061-dc8e-4856-b3c8-f42efa5225a3/?standalone=true"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2000,
                        Slug = "handbook-1",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1026&ext=png&k=",
                        Title = "Galileo, Bacon and Kepler: \"Travelling in Science\"",
                        Description = "<p>The current activity aims to explore the works of historical science figures - Galileo Galilei, Johannes Kepler, and Francis Bacon - to deepen students' understanding of the evolution of scientific thought, inspire curiosity about the world, and promote discussions on values like progress, experimentation, and evidence-based decision-making, especially in the context of modern challenges posed by technology. </p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Category = "Edu Activities",
                        TargetGroup = "High School",
                        Tags = new List<string>() {"resources"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=398&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2001,
                        Slug = "handbook-2",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1027&ext=png&k=",
                        Title = "Values travel through 'Antigone'",
                        Description = "<p>The educational activity “Values travel through 'Antigone” has been designed as\r\npart of the VAST project framework and is aimed at young people. This activity has\r\nbeen designed based on the principles of experiential learning and a collaborative\r\nteaching approach, where the active participation of students is encouraged\r\nthrough dialogue and practice, and has been piloted in the context of our\r\ncollaboration with schools and museums.\r\nAccording to the Council of Europe and the principles of democratic citizenship\r\nand human rights education, the educational process must, beyond imparting\r\nknowledge, aim at highlighting values, as well as cultivating attitudes and skills\r\naimed at raising awareness and to motivate young people for further thought and\r\nreflection.\r\nThis educational guide was designed to present and distribute recommended\r\neducational material to educators/museum curators who wish to work towards\r\nthis direction.\r\nEnjoy reading!\r\n</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 16-18",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=397&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2002,
                        Slug = "handbook-3",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1028&ext=png&k=",
                        Title = "Ethical dilemmas through the ancient Greek tragedies",
                        Description = "<p>The educational activity “Ethical dilemmas through the ancient Greek tragedies”\r\nhas been designed as part of the VAST project framework and is aimed at young\r\npeople. This activity has been designed based on the principles of experiential\r\nlearning and a collaborative teaching approach, where the active participation of\r\nstudents is encouraged through dialogue and practice, and has been piloted in the\r\ncontext of our collaboration with schools and museums.\r\nAccording to the Council of Europe and the principles of democratic citizenship\r\nand human rights education, the educational process must, beyond imparting\r\nknowledge, aim at highlighting values, as well as cultivating attitudes and skills\r\naimed at raising awareness and to motivate young people for further thought and\r\nreflection.\r\nThis educational guide was designed to present and distribute recommended\r\neducational material to educators/museum curators who wish to work towards\r\nthis direction.\r</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 16-18",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=396&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2003,
                        Slug = "handbook-4",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1029&ext=png&k=",
                        Title = "Clash of the Titans: Aristotle meets Galileo",
                        Description = "<p>The educational activity “Clash of the Titans: Aristotle meets Galileo” has been\r\ndesigned as part of the VAST project framework and is aimed at young people.\r\nThis activity has been designed based on the principles of experiential learning\r\nand a collaborative teaching approach, where the active participation of students\r\nis encouraged through dialogue and practice, and has been piloted in the context\r\nof our collaboration with schools and museums.\r\nAccording to the Council of Europe and the principles of democratic citizenship\r\nand human rights education, the educational process must, beyond imparting\r\nknowledge, aim at highlighting values, as well as cultivating attitudes and skills\r\naimed at raising awareness and to motivate young people for further thought and\r\nreflection.\r\nThis educational guide was designed to present and distribute recommended\r\neducational material to educators/museum curators who wish to work towards\r\nthis direction.\r</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 16-18",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=395&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2004,
                        Slug = "handbook-5",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1031&ext=png&k=",
                        Title = "From the Telescope to the Microscope: Useful and Entertaining Science",
                        Description = "<p>The current activity retraces some of the milestones of human progress\r\nthrough the accounts of Galileo Galilei, Vincenzo Viviani, and Robert Hooke,\r\nwith a particular emphasis on the freedom of scientific research and\r\ncontemplation of contemporary discoveries along with their moral\r\nimplications.\r\n</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 11-13",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=394&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2005,
                        Slug = "handbook-6",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1030&ext=png&k=",
                        Title = "Snow White and the Seven Dwarfs: Interactive Fairy Tale Storytelling for children",
                        Description = "<p>The educational activity entitled ‘Interactive Narration: Snow White & the Seven\r\nDwarfs' was designed in the context of the VAST project and targets children aged\r\n6 to 9 years old. This activity relies on the principles of non-formal education,\r\nwhere learning is achieved through interactive methodologies and tools such as\r\nrole-plays, video games and simulations.\r\nFairy tales are an excellent tool both for enhancing children's cognitive\r\ndevelopment and for helping them understand the norms and values that govern\r\ninterpersonal relationships and society in general. Through fairy tales, children\r\ncan identify with the hero, externalise deeper fears as well as comprehend and\r\nadapt values such as solidarity, empathy and kindness. This handbook is designed\r\nto provide suggested educational material for members of youth organisations,\r\nmuseums or schools who wish to work with the transmission of values through\r\nfairy tales.</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 6-9",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=393&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2006,
                        Slug = "handbook-7",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1032&ext=png&k=",
                        Title = "Galileo and Vespucci. In search of New Skies and New Lands for Great Opportunities",
                        Description = "<p>In this original theatrical play we follow two characters, Galileo Galilei and\r\nAmerigo Vespucci, talking about how they went beyond the boundaries\r\nbetween different worlds, cultures and tradition, following an anti-dogmatic\r\napproach.\r\n</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "High School",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=392&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2007,
                        Slug = "handbook-8",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1033&ext=png&k=",
                        Title = "Fantastic creatures in unknown lands",
                        Description = "<p>This activity engages participants in the exploration of hidden creatures\r\nwithin historical cartographic representations to facilitate discussions about\r\nthe challenges inherent in discovering new worlds and interpreting novel\r\nsocial and natural realities. It underscores the significance of tolerance and\r\ndialogue among diverse living beings and their importance in everyday life.\r\n</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 6-10",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=391&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2008,
                        Slug = "handbook-9",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1034&ext=png&k=",
                        Title = "Creative Writing: Values in Fairy Tales",
                        Description = "<p>The educational activity entitled 'Creative Writing: Values in Fairy Tales' was\r\ndesigned in the context of the VAST project and targets young people aged 12 and\r\nabove. This activity relies on the principles of non-formal education, where\r\nlearning is achieved through interactive methodologies and tools such as role\u0002plays, video games and simulations.\r\nAccording to the Council of Europe's European Youth Foundation, non-formal\r\neducation is complementary to formal and non-formal education and focuses on\r\ndelivering structured education which centralises on the active involvement of\r\nlearners. Participants are invited to be part of the process (expressing feelings,\r\nvalues and beliefs) by linking its content to their real life. Non-formal learning\r\nactivities aim to develop life skills as well as to strengthen the active citizenship of\r\nthe participants. This handbook has been designed to provide suggested training\r\nmaterial for members of youth organisations, museums or schools wishing to work\r\nin this direction.</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 12+",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=390&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2009,
                        Slug = "handbook-10",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1035&ext=png&k=",
                        Title = "Geographical discoveries, Astronomical Conquests and the New Representation of the World",
                        Description = "<p>In this activity the discovery of new worlds are paralleled with the\r\ncontemporary celestial discoveries of Galileo Galilei, offering the cue for\r\ndiscussion on the plurality of worlds and the multiplicity of perspectives\r\nleading to reflections on today’s world, the importance of evidence versus\r\ntradition, absence of prejudice, dialogue between different cultures.\r\n</p>",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 11-13",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=389&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2010,
                        Slug = "handbook-11",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1036&ext=png&k=",
                        Title = "The values travel through narrative - Create values logos",
                        Description = "<p>In this activity the discovery of new worlds are paralleled with the\r\ncontemporary celestial discoveries of Galileo Galilei, offering the cue for\r\ndiscussion on the plurality of worlds and the multiplicity of perspectives\r\nleading to reflections on today’s world, the importance of evidence versus\r\ntradition, absence of prejudice, dialogue between different cultures.\r\n</p>",
                        Author = "VAST Project",
                        Date = "17th of January 2024",
                        Tags = new List<string>() {"resources"},
                        Category = "Edu Activities",
                        TargetGroup = "Ages 7-12",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1213&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2030,
                        Slug = "handbook-12",
                        SmallImage = "https://dam.vast-project.eu/filestore/5/1/2/1_cc73776adeb94f8/1215scr_610c761f7f55038.jpg?v=1708367824",
                        Title = "VAST annotation methodology - narratives",
                        Description = "",
                        Author = "VAST Project",
                        Date = "16th of February 2024",
                        Tags = new List<string>() {"resources"},
                        Category = "Methodologies",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1215&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2031,
                        Slug = "handbook-13",
                        SmallImage = "https://dam.vast-project.eu/filestore/6/1/2/1_81b6e5efd9a8708/1216scr_7615fe39eb2ab4c.jpg?v=1708367960",
                        Title = "VAST annotation methodology - Images",
                        Description = "<p>In this activity the discovery of new worlds are paralleled with the\r\ncontemporary celestial discoveries of Galileo Galilei, offering the cue for\r\ndiscussion on the plurality of worlds and the multiplicity of perspectives\r\nleading to reflections on today’s world, the importance of evidence versus\r\ntradition, absence of prejudice, dialogue between different cultures.\r\n</p>",
                        Author = "VAST Project",
                        Date = "19th of February 2024",
                        Tags = new List<string>() {"resources"},
                        Category = "Methodologies",
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1216&ext=pdf&k="
                            }
                        },
                    },
                    new Article
                    {
                        Id = 2032,
                        Slug = "handbook-14",
                        SmallImage = "https://dam.vast-project.eu/filestore/4/1/2/1_77e22f8841999fa/1214scr_1d845a1e435a3cf.jpg?v=1708367816",
                        Title = "Co-creating Educational Activities",
                        Description = "",
                        Category = "Methodologies",
                        Author = "VAST Project",
                        Date = "17th of January 2024",
                        Tags = new List<string>() {"resources"},
                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "iframe",
                                Url = "https://dam.vast-project.eu/pages/download.php?direct=1&noattach=true&ref=1214&ext=pdf&k="
                            }
                        },
                    },
                    /*new Article()
                    {
                        Id = 100001,
                        Slug = "https://www.youtube.com/watch/SqK7SHMq8mI",
                        SmallImage = "https://img.youtube.com/vi/SqK7SHMq8mI/maxresdefault.jpg",
                        Title = "Values Across Space and Time",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100002,
                        Slug = "https://www.youtube.com/watch/YCqIGjWZ3lw",
                        SmallImage = "https://img.youtube.com/vi/YCqIGjWZ3lw/maxresdefault.jpg",
                        Title = "Intro On Values Across Space & Time",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },*/
                    new Article()
                    {
                        Id = 100003,
                        Slug = "https://www.youtube.com/watch/86gRmiVYhKQ",
                        SmallImage = "https://img.youtube.com/vi/86gRmiVYhKQ/maxresdefault.jpg",
                        Title = "VAST for Museum professionals",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Category = "Promos",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100004,
                        Slug = "https://www.youtube.com/watch/C1FVm7IRNjA",
                        SmallImage = "https://img.youtube.com/vi/C1FVm7IRNjA/maxresdefault.jpg",
                        Title = "Galileo, Bacone e Keplero: viaggio nella scienza",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Category = "Promos",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100005,
                        Slug = "https://www.youtube.com/watch/HpCKDMjJz4k",
                        SmallImage = "https://img.youtube.com/vi/HpCKDMjJz4k/maxresdefault.jpg",
                        Title = "Scoperte geografiche",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Category = "Promos",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100006,
                        Slug = "https://www.youtube.com/watch/4UD7NAjxHgs",
                        SmallImage = "https://img.youtube.com/vi/4UD7NAjxHgs/maxresdefault.jpg",
                        Title = "Conversing on the Cosmic Shore [In Italian]",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100007,
                        Slug = "https://www.youtube.com/watch/0RJSwhxRQvY",
                        SmallImage = "https://img.youtube.com/vi/0RJSwhxRQvY/hqdefault.jpg",
                        Title = "Using fairytales for therapy [In Greek]",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100008,
                        Slug = "https://www.youtube.com/watch/5Frki5HKgdA",
                        SmallImage = "https://img.youtube.com/vi/5Frki5HKgdA/hqdefault.jpg",
                        Title = "Communicating values through Ancient Drama",
                        Description = "A short set of videos to help you understand what the VAST project does and how it can help you",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "3rd of August 2023",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100009,
                        Slug = "https://www.youtube.com/watch?v=Ako8j3szAfs&amp;amp;amp;list=PL18_rB75vx1Mx7CSiPHZP11DCCtsOgrXU",
                        SmallImage = "https://img.youtube.com/vi/Ako8j3szAfs/hqdefault.jpg",
                        Title = "The “Trial of Antigone” as an intersection point",
                        Description = "The “Trial of Antigone” as an intersection point",
                        Author = "VAST Project",
                        Category = "Documentaries",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100010,
                        Slug = "https://youtu.be/McYs8OXPGQg?si=DOJxbN_qzZpDzS_M",
                        SmallImage = "https://img.youtube.com/vi/McYs8OXPGQg/hqdefault.jpg",
                        Title = "Mapping Ancient Comedy: Data, Limitations and Perspectives",
                        Description = "Mapping Ancient Comedy: Data, Limitations and Perspectives",
                        Author = "VAST Project",
                        Category = "Documentaries",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100011,
                        Slug = "https://www.youtube.com/watch?v=t5ClM34PqGY",
                        SmallImage = "https://img.youtube.com/vi/t5ClM34PqGY/hqdefault.jpg",
                        Title = "Concepts, values, and ideas in ancient drama: The research methodology of the past of values",
                        Description = "Concepts, values, and ideas in ancient drama: The research methodology of the past of values",
                        Author = "VAST Project",
                        Category = "Documentaries",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100012, // Adjust the ID as needed
                        Slug = "https://youtu.be/YLSWLmPdv6w?si=AKjUXtCo-DqDrbhM",
                        SmallImage = "https://img.youtube.com/vi/YLSWLmPdv6w/hqdefault.jpg",
                        Title = "What are values? From philosophy to science",
                        Description = "What are values? From philosophy to science",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "16th of February 2024", // Adjust the date as needed
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100013,
                        Slug = "https://youtu.be/H8eyDEwq2yM?si=Wp1QWFN92V-DuJws",
                        SmallImage = "https://img.youtube.com/vi/H8eyDEwq2yM/hqdefault.jpg",
                        Title = "How past becomes present in theatre performance [In Greek]",
                        Description = "How past becomes present in theatre performance [In Greek]",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100016,
                        Slug = "https://youtu.be/nHRyJ_eZifw?si=iOGvimOu6VqqhJQK",
                        SmallImage = "https://img.youtube.com/vi/nHRyJ_eZifw/hqdefault.jpg",
                        Title = "Once Upon a Value…",
                        Description = "Once Upon a Value…",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100017,
                        Slug = "https://youtu.be/_OW37py2c4k?si=WNRoCxDVLYcButFH",
                        SmallImage = "https://img.youtube.com/vi/_OW37py2c4k/hqdefault.jpg",
                        Title = "Promoting values through education",
                        Description = "Promoting values through education",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100019,
                        Slug = "https://youtu.be/gyTogid6aKc?si=g5NSVBvHDMWzpUgK",
                        SmallImage = "https://img.youtube.com/vi/gyTogid6aKc/hqdefault.jpg",
                        Title = "Values: from people to AI and back",
                        Description = "Values: from people to AI and back",
                        Author = "VAST Project",
                        Category = "Webinars",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100021,
                        Slug = "https://youtu.be/xw9GXOzRB94?si=aWXIla7n7rdxMQtE",
                        SmallImage = "https://img.youtube.com/vi/xw9GXOzRB94/hqdefault.jpg",
                        Title = "Carmen Gagliardi: Educational section, Galileo Museum",
                        Description = "Carmen Gagliardi: Educational section, Galileo Museum",
                        Author = "VAST Project",
                        Category = "Interviews",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100022,
                        Slug = "https://youtu.be/exin6PdCkwQ?si=cGYfKx_frhHgmCV1",
                        SmallImage = "https://img.youtube.com/vi/exin6PdCkwQ/hqdefault.jpg",
                        Title = "Cecilia Foianesi: Educational section, Galileo Museum",
                        Description = "Cecilia Foianesi: Educational section, Galileo Museum",
                        Author = "VAST Project",
                        Category = "Interviews",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100023,
                        Slug = "https://youtu.be/jQj2bQI4gqQ?si=2yanUDlHdjJ1GHnV",
                        SmallImage = "https://img.youtube.com/vi/jQj2bQI4gqQ/hqdefault.jpg",
                        Title = "Ilenia Ulivi: Educational section, Galileo Museum",
                        Description = "Ilenia Ulivi: Educational section, Galileo Museum",
                        Author = "VAST Project",
                        Category = "Interviews",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100024,
                        Slug = "https://youtu.be/Ng3KGA5beg8?si=oA_eNZeFGGPSlTQz",
                        SmallImage = "https://img.youtube.com/vi/Ng3KGA5beg8/hqdefault.jpg",
                        Title = "\"Amerigo and Vespucci discovering new worlds\": A theatrical performance",
                        Description = "\"Amerigo and Vespucci discovering new worlds\": A theatrical performance",
                        Author = "VAST Project",
                        Category = "Interviews",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100025,
                        Slug = "https://youtu.be/2JDLkDrSruM?si=mOuJaWYozWZQN7h5",
                        SmallImage = "https://img.youtube.com/vi/2JDLkDrSruM/hqdefault.jpg",
                        Title = "Natacha Fabbri: Researcher, Galileo Museum",
                        Description = "Natacha Fabbri: Researcher, Galileo Museum",
                        Author = "VAST Project",
                        Category = "Interviews",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },

                    new Article()
                    {
                        Id = 30101,
                        Slug = "vast-publications",
                        Title = "Publications",
                        SmallImage = "https://dam.vast-project.eu/pages/download.php?ref=1048&size=hpr&ext=jpg&k=&alternative=-1&iaccept=off&usage=-1&usagecomment=&email=",
                        Description = "Review the latest publications…",
                        Author = "VAST Project",
                        Date = "27th of January 2024",
                        Tags = new List<string>() { "publications" },
                        Sections = new List<Section>()
                        {
                            new Section()
                            {
                                Type="text",
                                Content = "<p>Visit the VAST site for the most recent publications.<p>\r\n"
                            },
                            new Section()
                            {
                                Type = "link",
                                Url = "https://www.vast-project.eu/presentations-publications/"
                            },
                        }
                    },
                    new Article
                    {
                        Id = 650000,
                        Slug = "values-of-ancient-drama-simos-kakalas",
                        SmallImage = "https://dam.vast-project.eu/filestore/3/2/0/1_5dea68c9dd27357/1023pre_a767cad7c2e18d3.jpg?v=1707818748",
                        Title = "The Values of Ancient Drama in the European CH: Simos Kakalas",
                        Description = "Exploring ancient drama's values with Simos Kakalas.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/3/2/0/1_5dea68c9dd27357/1023pre_a767cad7c2e18d3.mp4"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 650001,
                        Slug = "values-of-ancient-drama-niketi-kontouri",
                        SmallImage = "https://dam.vast-project.eu/filestore/2/2/0/1_c63f4a8f65dfa2c/1022pre_aa8b66d517381df.jpg?v=1707818526",
                        Title = "The Values of Ancient Drama in the European CH: Niketi Kontouri",
                        Description = "Exploring ancient drama's values with Niketi Kontouri.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/2/2/0/1_c63f4a8f65dfa2c/1022pre_aa8b66d517381df.mp4"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 650002,
                        Slug = "values-of-ancient-drama-michail-marmarinos",
                        SmallImage = "https://dam.vast-project.eu/filestore/1/2/0/1_c2182cea16614ed/1021pre_a36fce8943c67af.jpg?v=1707818414",
                        Title = "The Values of Ancient Drama in the European CH: Michail Marmarinos",
                        Description = "Exploring ancient drama's values with Michail Marmarinos.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/1/2/0/1_c2182cea16614ed/1021pre_a36fce8943c67af.mp4"
                            }
                        },
                    },
                    new Article
                    {
                        Id = 650003,
                        Slug = "values-of-ancient-drama-lydia-koniordou",
                        SmallImage = "https://dam.vast-project.eu/filestore/0/2/0/1_c2a0629ba8818a9/1020pre_240199b85aaef66.jpg?v=1707818282",
                        Title = "The Values of Ancient Drama in the European CH: Lydia Koniordou",
                        Description = "Exploring ancient drama's values with Lydia Koniordou.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/0/2/0/1_c2a0629ba8818a9/1020pre_240199b85aaef66.mp4"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 650004,
                        Slug = "values-of-ancient-drama-lilly-meleme",
                        SmallImage = "https://dam.vast-project.eu/filestore/9/1/0/1_3b95c6382681a6e/1019pre_d8715a7e3247a2b.jpg?v=1707818093",
                        Title = "The Values of Ancient Drama in the European CH: Lilly Meleme",
                        Description = "Exploring ancient drama's values with Lilly Meleme.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/9/1/0/1_3b95c6382681a6e/1019pre_d8715a7e3247a2b.mp4"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 650005,
                        Slug = "values-of-ancient-drama-katerina-evangelatos",
                        SmallImage = "https://dam.vast-project.eu/filestore/8/1/0/1_f56bbfb76cf3b50/1018pre_1e222db1c5caa41.jpg?v=1707817862",
                        Title = "The Values of Ancient Drama in the European CH: Katerina Evangelatos",
                        Description = "Exploring ancient drama's values with Katerina Evangelatos.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/8/1/0/1_f56bbfb76cf3b50/1018pre_1e222db1c5caa41.mp4"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 650006,
                        Slug = "values-of-ancient-drama-giorgos-skevas",
                        SmallImage = "https://dam.vast-project.eu/filestore/7/1/0/1_a6847d3e91b4401/1017pre_4c1b5d74b75c093.jpg?v=1707817802",
                        Title = "The Values of Ancient Drama in the European CH: Giorgos Skevas",
                        Description = "Exploring ancient drama's values with Giorgos Skevas.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/7/1/0/1_a6847d3e91b4401/1017pre_4c1b5d74b75c093.mp4"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 650007,
                        Slug = "values-of-ancient-drama-cezaris-grauzinis",
                        SmallImage = "https://dam.vast-project.eu/filestore/6/1/0/1_e4b94a8ec1efb61/1016pre_dbbb9562c34542e.jpg?v=1707817647",
                        Title = "The Values of Ancient Drama in the European CH: Cezaris Graužinis",
                        Description = "Exploring ancient drama's values with Cezaris Graužinis.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/6/1/0/1_e4b94a8ec1efb61/1016pre_dbbb9562c34542e.mp4"
                            }
                        },
                    },

                    new Article
                    {
                        Id = 650008,
                        Slug = "values-of-ancient-drama-argyro-chioti",
                        SmallImage = "https://dam.vast-project.eu/filestore/5/1/0/1_118adc50e6427fd/1015pre_a47963594530ece.jpg?v=1707817524",
                        Title = "The Values of Ancient Drama in the European CH: Argyro Chioti",
                        Description = "Exploring ancient drama's values with Argyro Chioti.",
                        Author = "VAST Project",
                        Date = "1st of November 2023",
                        Tags = new List<string>() {"video"},
                        Category = "Interviews",

                        Sections = new List<Section>
                        {
                            new Section()
                            {
                                Type = "htmlvid",
                                Url = "https://dam.vast-project.eu/filestore/5/1/0/1_118adc50e6427fd/1015pre_a47963594530ece.mp4"
                            }
                        },
                    },
                    new Article()
                    {
                        Id = 100031,
                        Slug = "https://www.youtube.com/watch?v=QQIqqc0WSXc",
                        SmallImage = "https://img.youtube.com/vi/QQIqqc0WSXc/hqdefault.jpg",
                        Title = "About VAST",
                        Description = "About VAST",
                        Author = "VAST Project",
                        Category = "Promos",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100032,
                        Slug = "https://www.youtube.com/watch?v=QvbfEBLjCgA",
                        SmallImage = "https://img.youtube.com/vi/QvbfEBLjCgA/hqdefault.jpg",
                        Title = "Dal telescopio al microscopio",
                        Description = "Dal telescopio al microscopio",
                        Author = "VAST Project",
                        Category = "Promos",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },
                    new Article()
                    {
                        Id = 100033,
                        Slug = "https://www.youtube.com/watch?v=L22AWKRJeG8",
                        SmallImage = "https://img.youtube.com/vi/L22AWKRJeG8/hqdefault.jpg",
                        Title = "Creature fantastiche",
                        Description = "Creature fantastiche",
                        Author = "VAST Project",
                        Category = "Promos",
                        Date = "16th of February 2024",
                        Tags = new List<string>() { "video" },
                    },


                };


        public List<Article> GetArticles(string query, string tag = null)
        {
            List<Article> prefiltered = articles;

            //Prefilter by tag
            if (!string.IsNullOrEmpty(tag))
            {
                prefiltered = articles.Where(a => a.Tags.Contains(tag)).ToList();
            }

            //Filter the articles where the title or description contains the query
            if (!string.IsNullOrEmpty(query))
            {
                //First, break down the query into words and remove the empty ones
                var queryWords = query.Split(' ').Where(w => !string.IsNullOrWhiteSpace(w)).ToList();

                //Now, filter the articles where the title or description contains all the words
                prefiltered = prefiltered.Where(a =>
                    queryWords.All(w => a?.Title?.ToLower()?.Contains(w.ToLower()) == true ||
                                              a?.Description?.ToLower()?.Contains(w.ToLower()) == true ||
                                              a?.Tags?.Any(t => (t?.ToLower()?.Contains(w.ToLower())) == true) == true ||
                                              a?.Sections?.Any(s => (s?.Content?.ToLower()?.Contains(w.ToLower())) == true) == true
                                  )
                    ).ToList();
            }

            return prefiltered;
        }

        public List<Article> GetGames(string query)
        {
            return GetArticles(query, "games");
        }

        public List<Article> GetServices(string query)
        {
            return GetArticles(query, "tools");
        }

        public List<Article> GetResources(string query)
        {
            return GetArticles(query, "resources");
        }

        public Article GetArticle(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            if (int.TryParse(id, out int idNumeric))
            {
                return articles.FirstOrDefault(g => g.Id == idNumeric);
            }
            else
            {
                return articles.FirstOrDefault(g => g.Slug.ToLower() == id.ToLower());
            }
        }
    }
}
