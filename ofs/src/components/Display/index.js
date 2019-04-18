import store from '@/store'
export default {
  methods: {
  },
  mounted () {
    console.log(store)
  },
  provide: {
    app: store.getters.getFormData
  },
  data () {
    return {
      text: '22332',
      formData: store.getters.getFormData
    }
  },
  watch: {

  }

}
