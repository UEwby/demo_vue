// const target = `http://192.168.133.152:8080`
const target = 'http://39.105.81.29:80'

module.exports = {
  proxyList: {
    '/api': {
      // 测试环境
      target: target, // 接口域名
      changeOrigin: false, // 是否跨域
      pathRewrite: {
        '^/api': '' // 需要rewrite重写的,
      }
    },
    '/connect': {
      // 测试环境
      target: 'http://192.168.133.153:5000', // 接口域名
      changeOrigin: true, // 是否跨域
      pathRewrite: {
        '^/connect': '' // 需要rewrite重写的 ,
      }
    }
  }
}
