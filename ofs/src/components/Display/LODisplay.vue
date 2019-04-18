<template>
    <div ref="display"></div>
</template>
<script>
import Vue from 'vue'
import m from './index.js'
import randomStr from '@/utils/randomStr.js'
export default {
  props: {
    code: {
      type: String,
      default: ''
    }
  },
  data () {
    return {
      id: randomStr(),
      html: '',
      js: '',
      css: '',
      component: null
    }
  },
  watch: {
    code () {
      this.destroyCode()
      this.renderCode()
    }
  },
  methods: {
    getSource (source, type) {
      const regex = new RegExp(`<${type}[^>]*>`)
      let openingTag = source.match(regex)

      if (!openingTag) return ''
      else openingTag = openingTag[0]

      return source.slice(source.indexOf(openingTag) + openingTag.length, source.lastIndexOf(`</${type}>`))
    },
    splitCode () {
      const script = this.getSource(this.code, 'script').replace(/export default/, 'return ')
      const style = this.getSource(this.code, 'style')
      const template = this.getSource(this.code, 'template')

      this.js = script
      this.css = style
      this.html = template
    },
    renderCode () {
      this.splitCode()

      if (this.html !== '' && this.js !== '') {
        /* eslint-disable */
        const parseStrToFunc = new Function(this.js)()
        /* eslint-enable */
        parseStrToFunc.template = this.html
        parseStrToFunc.mixins = [m]
        // import m from '@/mixins/m.js'
        const Component = Vue.extend(parseStrToFunc)
        this.component = new Component().$mount()

        this.$refs.display.appendChild(this.component.$el)

        if (this.css !== '') {
          const style = document.createElement('style')
          style.type = 'text/css'
          style.id = this.id
          style.innerHTML = this.css
          document.getElementsByTagName('head')[0].appendChild(style)
        }
      }
    },
    destroyCode () {
      const $target = document.getElementById(this.id)
      if ($target) $target.parentNode.removeChild($target)

      if (this.component) {
        this.$refs.display.removeChild(this.component.$el)
        this.component.$destroy()
        this.component = null
      }
    }
  },
  mounted () {
    this.renderCode()
  },
  beforeDestroy () {
    this.destroyCode()
  }
}
</script>
