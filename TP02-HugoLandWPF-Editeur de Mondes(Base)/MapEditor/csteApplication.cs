﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoLandEditeur
{
    public static class csteApplication
    {
        public const int DEFAULT_TILE = 10;

        public const int BUFFER_WIDTH = 16;
        public const int BUFFER_HEIGHT = 16;
        public const int ZOOM = 2;

        public const int MAPFILE_ID = 0x1222;
        public const int MAP_MAX_SIZE = 64000;

        public const int DEFAULT_WORLD_WIDTH = 64;
        public const int DEFAULT_WORLD_HEIGHT = 64;

        public const int TILE_WIDTH_IN_IMAGE = 64;
        public const int TILE_HEIGHT_IN_IMAGE = 64;

        public const int TILE_WIDTH_IN_LIBRARY = 32;
        public const int TILE_HEIGHT_IN_LIBRARY = 32;
        public const int TILE_WIDTH_IN_MAP = 16;
        public const int TILE_HEIGHT_IN_MAP = 16;

        public const string TILE_FILE_PATH = "\\GameData\\AllTiles.png";

    }
}
