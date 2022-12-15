# Changelog

## Notes
- Whenever you make changes to the project's code, put a mildly-detailed description of changes you made in this file under the Next Version header. Use one bullet point per change.
- Each breaking change should be preceded with `**BREAKING CHANGE**:` in the changelog entry. The minor version (major when we hit v1.0.0) should also increase accordingly.
- When the new version is ready, rename the header to the version number. After that, create the according tag. Also make sure to change the package.json version as well.

## Next Version
- Made some clarifications in the changelog
- Fixed terrain not getting updated probably when first clicking the button

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