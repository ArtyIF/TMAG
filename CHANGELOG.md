# Changelog

## Notes
- Whenever you make changes to the project's code, put a mildly-detailed description of changes you made in this file under the Upcoming Release header. Use one bullet point per change.
- Each breaking change should be preceded with `**BREAKING CHANGE**:` in the changelog entry. The minor version (major when we hit v1.0.0) should also increase accordingly. If it's an upcoming release, put the next version in brackets.
- When the new version is ready, rename the header to the version number. After that, create the according tag. Also make sure to change the package.json version as well.

## Upcoming Release
- Texture Node now uses the smallest of dimensions instead of width for calculating input resolution. This isn't considered breaking as this node is meant to be used with heightmaps or splatmaps, i.e. textures that are usually square
- Added check that compute shaders and random write textures are actually supported
- Switched to RFloat texture format, which allows Constant Node values to finally be more than 1
- Math operators now can output values bigger than 1

## v0.4.0
- Wrote some compute shader replacements for regular shaders
- **BREAKING CHANGE**: Moved to compute shaders! They work pretty well for the most part. When creating your own nodes, make sure to assign the compute shader in the MonoBehaviour asset inspector window
- **BREAKING CHANGE**: The Value Noise and Slope nodes are gone. Value Noise probably forever, Slope only temporarily
- **BREAKING CHANGE**: Fixed errors when textures are not set. Custom nodes need to override AllTexturesAreNotNull similar to built-in nodes when using own textures
- When for whatever reason a node outputs null, a warning is now displayed

## v0.3.0
- Some updates to README and changelog
- Fixed RAW to texture tool's settings not working
- Removed grid size parameter for now
- **BREAKING CHANGE** (reverted): hidePreview is now a parameter to allow overriding the default value
- Constant node now hides preview by default
- ConstantFloatNode.cs moved to ConstantNode.cs. This one is probably not a breaking change since the class name and the .meta file are the same
- Undone the hidePreview change due to errors it caused (while still keeping the new constant node preview behavior)
- **BREAKING CHANGE**: Changed the order of assigning heights to be more correct

## v0.2.3
- Moved properties on written shaders to a cbuffer. I don't think it does much, but it does make Unity complain less about SRP support
- Added extra delay before updating the terrain maps because I just had the bug happen on me again for some reason
- Some README and changelog notes updates
- Tile size is now a Vector3 instead of a float
- Fixed the deferred terrain update mechanism
- Removed unused using statements
- Added Toggle Preview button to nodes
- Removed spacing between parameters and previews in nodes
- Bumped minimum Unity version to better reflect dependencies' minimum versions
- Hid automatically-set settings on graph object in inspector to avoid confusion

## v0.2.2
- Made some clarifications in the changelog
- Fixed terrain not getting updated probably when first clicking the button
- Added Slope node, which is similar to Steepness but it adds parameters to specify the range of the gradient outputted. It will be useful for texturing cliffs when that gets added later
- Assigned default values to noise nodes

## v0.2.1
- Fixed backing value for node inputs (i.e. the Custom Render Texture selection) being shown
- Removed unused output from Heightmap node
- Added an extra node base and made the shader node base inherit it
- Made the node graph use Shader Graph-like noodle type
- Added an experimental Steepness node, which outputs the gradient between surfaces. Unfortunately, it looks pretty broken right now

## v0.2.0
- Added Perlin noise
- Added Simplex noise
- **BREAKING CHANGE**: Renamed Simple noise to Value noise to avoid confusion
- Made the package description a bit "funnier"

## v0.1.0
- Initial commit