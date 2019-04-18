import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    formData: {
    },
    formSetting: []
  },
  getters: {
    getFormData: state => state.formData,
    getSettingByName: state => data => {
      let name = data.name
      let belong = data.belong
      let arr = []
      // 控件属于主表
      if (belong === '') {
        arr = state.formSetting.filter(item => { return item.id === name })
      } else { // 控件属于细表
        for (let field of state.formSetting) {
          // 找到指定细表对象下的集合
          if (field.id === belong) {
            // 细表对象下配置属性
            arr = field.items.filter(item => { return item.id === name })
            break
          }
        }
      }
      if (arr.length > 0) {
        return arr[0]
      } else {
        return null
      }
    }
  },
  mutations: {
    setFormData (state, data) {
      state.formData = data
    },
    setFormSetting (state, data) {
      state.formSetting = data
    },
    setFormDataByName (state, data) {
      let belong = data.belong
      if (belong === '') {
        state.formData[data.name] = data.value
      } else {

      }
    }

  }
})
