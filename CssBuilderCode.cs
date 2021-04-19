using System;


namespace Builder
{
    class program { 
    static void Main(string[] args)
        {
            CssBuilder css = new CssBuilder();
            string cssCode =css.begin("p").content(" /*  Paragraph style */ ").end().get();

            Console.WriteLine(cssCode);
        }
    }
    class CssBuilder
    {
        private string css;
        public CssBuilder()
        {
            this.css = " ";
        }
        public CssBuilder begin(string value)
        {
            this.css +=  value+" {";
            return this;
        }
        public CssBuilder content(string value)
        {
            this.css += " " + value + " ";
            return this;

        }
        public CssBuilder end() { 
            this.css += "}";
            return this;
        }
        public string get()
        {
            return this.css;
        }
    }


    }
