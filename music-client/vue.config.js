const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true,
  chainWebpack: config => {
    config.plugin('define').tap(definitions => {
      if (process.env.NODE_ENV === 'prod') {
        Object.assign(definitions[0]['process.env'], {
          NODE_HOST: '"http://localhost:9011"',
        });
      } else {
        Object.assign(definitions[0]['process.env'], {
          NODE_HOST: '"http://localhost:9011"',
        });
      } 
      return definitions;
    });
  }
})
