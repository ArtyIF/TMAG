# Changelog

## Notes
- Whenever you make a commit, put a mildly-detailed description of changes you made in this file under the Next Version header.
- If you made multiple changes a commit, break it into multiple bullet points.
- Each breaking change should be preceded with `**BREAKING CHANGE**:` in the changelog entry. The minor version (major when we hit v1.0.0) should also increase accordingly.
- End each point with your GitHub username with the @ symbol in brackets, e.g.: `Made changes (@ArtyIF)`.
- When the new version is ready, the commit hash should be added to each point, e.g.: `Made changes (@ArtyIF, 2ef7bde608ce5404e97d5f042f95f89f1c23287)`. The hash will be converted into a link by GitHub automatically. The header should also be renamed to the version number. After that, create the according tag. Also make sure to change the package.json version as well.

## Next Version
- Made some clarifications in the changelog (@ArtyIF)

## v0.2.1
- Fixed backing value for node inputs (i.e. the Custom Render Texture selection) being shown (@ArtyIF, 1037a78c0831ee753fbb3d04c4e15533160e402c)
- Removed unused output from Heightmap node (@ArtyIF, 84f266c31217caf4128076bb7cadf241e98617df)
- Added an extra node base and made the shader node base inherit it (@ArtyIF, 84f266c31217caf4128076bb7cadf241e98617df)
- Fixed regression introduced by 84f266c31217caf4128076bb7cadf241e98617df with Heightmap not displaying node preview anymore (@ArtyIF, a5efaa0045b2a8dbe6b9459a088fbb2b6dbb2142)
- Made the node graph use Shader Graph-like noodle type (@ArtyIF, a5efaa0045b2a8dbe6b9459a088fbb2b6dbb2142)
- Added an experimental Steepness node, which outputs the gradient between surfaces. Unfortunately, it looks pretty broken right now (@ArtyIF, 830cdb7a011251cabdacb2889cd8cbc63504e6bc)

## v0.2.0
- Added Perlin noise (@ArtyIF, 88f7b55dc396dc10cd12faa5d613c2d36adfc6d2)
- Added Simplex noise (@ArtyIF, 00f2c1f54aa2f2899191b2eee09c3282034442e3)
- **BREAKING CHANGE**: Renamed Simple noise to Value noise to avoid confusion (@ArtyIF, fa7cb4276acdabd308a86de5022c40d7e620e6b7)
- Made the package description a bit "funnier" (@ArtyIF, ea83df6fb2fdde469819b1b00c1aaa823eb47056)

## v0.1.0
- Initial commit (@ArtyIF, 557553251979a70c40224d46f537516aee9cc314)