export const toggle = {
  data () {
    return {
      isshowing: false,
      str: '55555'
    }
  },
  methods: {
    toggleShow () {
      this.isshowing = !this.isshowing
    },
    fn2 () {
      console.log('11111')
    }
  },
  created () {
    console.log('混入对象的钩子被调用')
  }
}
