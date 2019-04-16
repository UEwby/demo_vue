<template>
  <div>
    <h1>登陆中</h1>
  </div>
</template>

<script>
import axios from 'axios'
import store from '../../store'
export default {
  name: 'Login',
  data () {
    return {
      otac: ''
    }
  },
  mounted () {
    this.login()
  },
  methods: {
    login () {
      const instance = axios.create({
        baseURL: 'connect',
        headers: {
          'Authorization': 'Basic cGNfY2xpZW50OnNlY3JldA==',
          'Content-Type': 'application/x-www-form-urlencoded',
          timeout: 10000
        }
      })
      this.otac = this.getUrlKey('otac')
      if (this.otac) {
        instance.post(`/connect/token`, `grant_type=password&username=OTAC&password=${this.otac}&scope=im api-gw openid profile email phone address offline_access lo_gw`).then(res => {
          store.commit('login', {otac: this.otac, token: res.data.access_token})
          let redirect = decodeURIComponent(this.$route.query.redirect || '/')
          this.$router.push({
            path: redirect
          })
        })
      }
    },
    getUrlKey: function (name) {
      // 取URL里面的otac因为otac在#前面
      return decodeURIComponent((new RegExp('[?|&]' + name + '=' + '([^&;]+?)(&|#|;|$)').exec(location.href))[1].replace(/\+/g, '%20')) || null
    }
  }
}
</script>

<style lang="scss">
body {
  min-height: 100%;
}

h1 {
  position: absolute;
  left: 50%;
  margin-left: -1.9em;
  color: hsla(0, 0%, 80%, 0.3);
  font: 900 800% Baskerville, "Palatino Linotype", Palatino, serif;
}

@keyframes loading {
  from {
    max-width: 0;
  }
}

h1:before {
  content: attr(data-content);
  position: absolute;
  overflow: hidden;
  max-width: 4em;
  color: white;
  animation: loading 10s linear;
}
</style>
