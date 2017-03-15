using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ZeldaEngine
{
    class ResourceManager
    {
        private readonly ContentManager content;
        private Dictionary<string, Texture2D> textures;

        public ResourceManager(ContentManager content)
        {
            this.content = content;
            textures = new Dictionary<string, Texture2D>();
        }

        public Texture2D LoadTexture(string fileName)
        {
            if (textures.ContainsKey(fileName))
            {
                return textures[fileName];
            }

            var texture = content.Load<Texture2D>(string.Format(@"Images\{0}", fileName));
            textures.Add(fileName, texture);
            return texture;
        }

        public void Clear()
        {
            textures.Clear();
        }
    }
}
