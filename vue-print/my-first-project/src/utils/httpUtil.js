/**
 * Created by wangbinyan on 2019/1/30.
 */
var Fly = require("../lib/wx") //wx.js为您下载的源码文件
// var Fly=require("flyio/dist/npm/wx") //npm引入方式
var fly=new Fly(); //创建fly实例

//添加拦截器
fly.interceptors.request.use((config,promise)=>{
    //给所有请求添加自定义header
    config.headers["X-Tag"]="flyio";
    return config;
})
//配置请求基地址
fly.config.baseURL="https://wendux.github.io/"

Page({
  //事件处理函数
  bindViewTap: function() {
    //调用
    fly.get("http://10.10.180.81/doris/1/1.0.0/user/login",{xx:6}).then((d)=>{
      //输出请求数据
      console.log(d.data)
      //输出响应头
      console.log(d.header)
    }).catch(err=>{
      console.log(err.status,err.message)
    })
  }
})