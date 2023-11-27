# TMAG (abandoned!)
*Terrain Modifier And Generator*

As I moved away from Unity, I'll no longer work on this project.

## Description
TMAG is a node-based tool to generate terrains and modify pre-created ones. It's currently at a very early stage, but it's pretty usable with several caveats.

Most built-in nodes are powered by compute shaders rendering to Render Textures, making terrain generation a lot faster compared to other free alternatives like [MapMagic 2](https://assetstore.unity.com/packages/tools/terrain/mapmagic-2-165180). The node-based architecture also makes it much more flexible and customizable than a lot of other free terrain generators, which usually rely on Perlin noise only.

## Dependencies
- From Unity registry (should get installed automatically):
  - Shader Graph
- From OpenUPM:
  - [xNode](https://github.com/Siccity/xNode/)
  - [Tri Inspector](https://github.com/codewriter-packages/Tri-Inspector) (don't forget to run the Installer!)
  - [Keijiro's Noise Shader Library](https://github.com/keijiro/NoiseShader)

To install packages from OpenUPM, you can either use [openupm-cli](https://openupm.com/docs/getting-started.html) or manually add the scoped registry under Project Settings - Package Manager:
- Name: `OpenUPM`
- URL: `https://package.openupm.com`
- Scopes:
  - `com.github.siccity.xnode`
  - `com.codewriter.triinspector`
  - `jp.keijiro.noiseshader`

## Install
1. Set up dependencies
2. Open Window - Package Manager
3. Click the plus button and select "Add package from git URL..."
4. Type `https://github.com/ArtyIF/TMAG.git` and click the "Add" button

## Features and Roadmap (no particular order)
- [x] Value, Perlin and Simplex noise generation
- [x] Texture import
- [ ] Other generators
- [x] Tool to convert RAW heightmap exports to regular Textures
- [x] Basic math operators (Add, Subtract, Multiply, Divide)
- [ ] More math operators
- [x] Steepness operatos
- [ ] More terrain-specific operators
- [x] Heightmap output
- [ ] Splatmap output
- [ ] Detail output
- [ ] Terrain grid
- [ ] Export terrains to asset
- [ ] Infinite terrain?
- [ ] Phase out Tri Inspector? Having to install the Installer as well is cumbersome, and I don't see any benefit with this
- [x] Move to compute shaders
- [ ] Move to shader generation? Should solve potential OoB issues
- [ ] Come up with more features

## Thanks
- Denis Pahunov for creating [MapMagic 2](https://assetstore.unity.com/packages/tools/terrain/mapmagic-2-165180), which is an incredibly powerful (although slow on Linux Editor) free tool (with extra paid extensions) for terrain generation
- Any contributors. If you aren't one, don't be afraid!
