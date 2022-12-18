# Changelog

## Notes
- Whenever you make changes to the project's code, put a mildly-detailed description of changes you made in this file under the Upcoming Version header. Use one bullet point per change.
- Each breaking change should be preceded with `**BREAKING CHANGE**:` in the changelog entry. The minor version (major when we hit v1.0.0) should also increase accordingly.
- When the new version is ready, rename the header to the version number. After that, create the according tag. Also make sure to change the package.json version as well.

## Upcoming Version
- Moved properties on written shaders to a cbuffer. I don't think it does much, but it does make Unity complain less about SRP support
- Added extra delay before updating the terrain maps because I just had the bug happen on me again for some reason
- Some README and changelog notes updates
- Tile size is now a Vector3 instead of a float
- Fixed the deferred terrain update mechanism
- Removed unused using statements
- Added Toggle Preview button to nodes

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