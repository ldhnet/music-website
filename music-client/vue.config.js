const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true,
  chainWebpack: config => {
    config.plugin('define').tap(definitions => {
      if (process.env.NODE_ENV === 'prod') {
        Object.assign(definitions[0]['process.env'], {
          NODE_HOST: '"http://124.223.117.49:9005"',
        });
      } else {
        Object.assign(definitions[0]['process.env'], {
          NODE_HOST: '"http://124.223.117.49:9005"',
        });
      } 
      return definitions;
    });
  }
})
