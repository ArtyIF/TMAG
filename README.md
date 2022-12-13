# TMAG
*Terrain Modifier And Generator*

## Description
TMAG is a node-based tool to generate terrains and modify pre-created ones. It's currently at a very early stage, but it's pretty usable with several caveats.

Most built-in nodes are powered by Shader Graphs rendering to Custom Render Textures, making terrain generation quite a bit faster than other free alternatives like [MapMagic 2](https://assetstore.unity.com/packages/tools/terrain/mapmagic-2-165180). The node-based architecture also makes it much more flexible and customizable than a lot of other free terrain generators, which usually rely on Perlin noise only.

## Requirements
- Shader Graph
- [xNode](https://github.com/Siccity/xNode/)
- [Tri Inspector](https://github.com/codewriter-packages/Tri-Inspector) (don't forget to run the Installer!)

## Features and Roadmap
- [x] Simple noise generation
- [ ] Other noises generation
- [ ] Other generators
- [x] Texture import
- [x] Tool to convert RAW heightmap exports to regular Textures
- [x] Basic math operators (Add, Subtract, Multiply, Divide)
- [ ] More math operators
- [ ] More terrain-specific operators, like Slope and Erosion
- [x] Heightmap output
- [ ] Splatmap output
- [ ] Detail output
- [ ] Come up with more features
- [ ] Terrain grid
- [ ] Infinite terrain?
- [ ] Phase out Tri Inspector and xNode?
- [ ] Move to Compute Shaders? Render Textures have a lot of issues with them

## Known Bugs (move to issues)
- Because of how render textures work, sometimes you need to click the Generate button twice

## Thanks
- Denis Pahunov for creating [MapMagic 2](https://assetstore.unity.com/packages/tools/terrain/mapmagic-2-165180), which is an incredibly powerful (although slow on Linux Editor) free tool (with extra paid extensions) for terrain generation
- Any contributors. If you aren't one, don't be afraid!