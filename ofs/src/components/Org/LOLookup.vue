<template>
  <div @click="edit" class="lo-box">
   <Underline v-show="!isEdit" v-model="userData"></Underline>
    <el-input style="width:100%" @blur="check" @click.native="openSelectPerson" ref="LOLookup" v-show="isEdit" placeholder="请选择部门" v-model="userData"   suffix-icon="el-icon-search" class="input-with-select">
    </el-input>
      <el-dialog
      title="选择部门"
      :visible="showSelectUser"
      width="30%">
      <SelectDept v-bind:callback="selectUserCallBack"></SelectDept>
    </el-dialog>
  </div>
</template>

<script>
import Underline from '@/components/Line/LOLine'
import SelectDept from './SelectDept'

export default {
  name: '',
  components: {
    SelectDept, Underline
  },
  props: {},
  data () {
    return {
      isEdit: false,
      showSelectUser: false,
      userData: ''
    }
  },
  computed: {},
  created () {},
  mounted () {},
  methods: {
    edit () {
      this.isEdit = true
    },
    check (e) {
      this.isEdit = false
    },
    openSelectPerson () {
      this.showSelectUser = true
    },
    selectUserCallBack (users) {
      this.userData = users
      this.showSelectUser = false
    }
  },
  watch: {
    isEdit (val) {
      this.$nextTick(() => {
        this.$refs.LOLookup.focus()
      })
    }
  }
}
</script>

<style scoped>
.lo-box{
    height: 100%;
    width: 100%;
    display: flex;
    flex-direction: column ;
    justify-content: flex-end;
    align-items: center;
}
</style>
