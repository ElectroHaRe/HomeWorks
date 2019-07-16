using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Store
    {
        public Store() {
            articles = new Article[3] { new Article("Chips", "BestShopEver", "0.5"), new Article("Sosisa", "MyausoMyaugic", "3"), new Article("Meh", "TwichMemeses", "5") };
        }

        private Article[] articles;

        public Article this[int index] {
            get {
                return index > articles.Length - 1 ? null : articles[index];
            }
        }

        public Article this[string name] {
            get {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].name.ToLower() == name.ToLower())
                        return articles[i];
                }
                return null;
            }
        }
    }
}
