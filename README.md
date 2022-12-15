# TMAG
*Terrain Modifier And Generator*

## Description
TMAG is a node-based tool to generate terrains and modify pre-created ones. It's currently at a very early stage, but it's pretty usable with several caveats.

Most built-in nodes are powered by shaders (Shader Graphs and coded shaders) rendering to Custom Render Textures, making terrain generation quite a bit faster than other free alternatives like [MapMagic 2](https://assetstore.unity.com/packages/tools/terrain/mapmagic-2-165180). The node-based architecture also makes it much more flexible and customizable than a lot of other free terrain generators, which usually rely on Perlin noise only.

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

## Features and Roadmap
- [x] Value, Perlin and Simplex noise generation
- [x] Texture import
- [ ] Other generators
- [x] Tool to convert RAW heightmap exports to regular Textures
- [x] Basic math operators (Add, Subtract, Multiply, Divide)
- [ ] More math operators
- [ ] More terrain-specific operators, like Slope and Erosion
- [x] Heightmap output
- [ ] Splatmap output
- [ ] Detail output
- [ ] Terrain grid
- [ ] Infinite terrain?
- [ ] Phase out Tri Inspector?
- [ ] Move to Compute Shaders? Render Textures have a lot of issues with them
- [ ] Or maybe move to shader generation? Should solve potential OoB issues
- [ ] Come up with more features

## Thanks
- Denis Pahunov for creating [MapMagic 2](https://assetstore.unity.com/packages/tools/terrain/mapmagic-2-165180), which is an incredibly powerful (although slow on Linux Editor) free tool (with extra paid extensions) for terrain generation
- Any contributors. If you aren't one, don't be afraid!