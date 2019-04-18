<template>
  <div id="SelectDept" style="width: 500px;height: 320px;margin: 0 auto;display: flex;justify-content:space-between;flex-direction:column;">
    <!--树查询-->
    <!--<div style="display: flex;height: 30px;background:rgb(240,240,240)">-->
    <div style="display: flex;height: 30px;">
    <div  style="display: flex;width: 200px;height: 30px;">
      <el-input :clearable="true" size="mini"  placeholder="请输入内容" v-model="searchText" class="input-with-select">
        <el-button size="mini" slot="append" icon="el-icon-search" @click="searchNode"></el-button>
      </el-input>
   </div>
    </div>
    <div style="overflow:auto;display: flex;width: 500px;height: 250px;margin: 0 auto;">
      <!--树-->
      <el-tree v-show="showTree"
               :data="data"
               :props="defaultProps"
               lazy
               :default-expand-all="true"
               :load="loadNode"
               :expand-on-click-node="true"
               :show-checkbox="multiSelect"
               class="org-tree"
               ref="tree"
               node-key="orderNum"
               unselectable="on"
               :render-content="renderContent" @node-click="handleNodeClick"></el-tree>
      <!--查询结果-->
      <el-table
        ref="singleTable"
        :data="tableData"
        highlight-current-row
        @current-change="handleCurrentChange"
        style="width: 100%">
        <el-table-column
          property="name"
          label="名称"
          width="100">
        </el-table-column>
        <el-table-column
          property="code"
          label="编码"
          width="100">
        </el-table-column>
        <el-table-column
          property="path"
          label="全路径">
        </el-table-column>
      </el-table>
    </div>
    <div style="display: flex;width: 500px;height: 40px;justify-content: flex-end;align-items: center">
      <el-button size="small" type="primary"  @click="getCheckedNodes">确定</el-button>
      <el-button size="small" type="primary" style="margin-right: 10px"  @click="cancelSelect" >取消</el-button>
    </div>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
import store from '@/store'
export default {
  name: 'SelectDept',
  props: {
    value: {
      type: String,
      default: ''
    },
    multiSelect: {
      type: Boolean,
      default: false
    },
    authCode: {
      type: String,
      default: null // 'GLKM.AuthTest.QXModule.Add'
    },
    callback: {}
  },
  data () {
    return {
      data: [],
      searchText: '',
      currentUserId: -1,
      defaultProps: {
        children: 'children',
        label: 'label',
        isLeaf: 'leaf'
      },
      authUnit: {
        deptIds: [], // 授权的部门
        deptVisableParentlds: [], // 授权部门的上级节点
        isLimited: false // 是否有范围限制
      },
      showTree: true,
      tableData: []
    }
  },
  computed: {
    ...mapGetters([
      'getDeptComBack'
    ])
  },
  methods: {
    handleCurrentChange () {

    },
    searchNode () {
      if (this.searchText) {
        this.showTree = false
      }
    },
    getCheckedNodes () {
      store.state.formData.SSBM = this.$refs.tree.getCurrentNode().Name
      this.callback(this.$refs.tree.getCurrentNode().Name)
      // if (this.multiSelect) {
      //   let depts = []
      //   let nodes = this.$refs.tree.getCheckedNodes()
      //   nodes.forEach((item, index) => {
      //     if (item.type === 1) {
      //       depts.push(item)
      //     }
      //   })
      //   if (depts.length > 0) {
      //     // vuex存储
      //     this.$store.commit('setDeptComBack', depts)
      //     // 回调方法
      //     if (this.callback) {
      //       this.callback(depts)
      //     }
      //   }
      //   // console.log(this.$refs.tree.getCheckedNodes())
      // } else {
      //   let dept = this.$refs.tree.getCurrentNode()
      //   if (dept.type === 1) {
      //     // vuex存储
      //     this.$store.commit('setDeptComBack', dept)
      //     // 回调方法
      //     if (this.callback) {
      //       this.callback(dept)
      //     }
      //   }
      // console.log(this.$refs.tree.getCurrentNode())
      // }
    },
    getAuthDept () {
      this.getRoot()
    },
    cancelSelect () {
      this.$refs.tree.setCheckedKeys([])
      store.commit('setDeptComBack', null)
      if (this.callback) {
        this.callback(null)
      }
    },
    loadNode (node, resolve) {
      if (node.id !== 0 && node.data.type === 0) {
        setTimeout(() => { this.addChildNode(node, resolve) }, 200)
      } else {
        resolve([])
      }
    },
    renderContent (h, { node, data, store }) {
      return (
        <span class="custom-tree-node">
          <span class={data.className}></span>
          <span style="font-size:14px">{node.label}</span>
        </span>
      )
    },
    handleNodeClick (data) {
      // this.addChildNode(data)
    },
    addChildNode (node, resolve) {
      let self = this
      let postData = {
        controller: 'GTP.Org.Action.CommonObjectService',
        action: 'GetChildOrgUnitListXXNew',
        args: [node.data.id, 0, 'Dept', false, false, true, false, this.authCode, false, true, 2]
      }
      this.$http.post('/vueapi/org.ashx', postData
      ).then((response) => {
        let result = JSON.parse(response.data.Data)
        // console.log(result)
        let nodeList = []
        result.forEach((item, index) => {
          // let child = {}
          if (self.isContained(self.authUnit.deptVisableParentlds, item.Id.toString()) || !self.authUnit.isLimited) {
            let child = item
            child.id = item.Id
            child.type = item.ObjType
            child.label = item.Name
            child.children = []
            child.leaf = item.Leaf
            if (item.ObjType === 0) {
              child.className = 'i-dept'
              child.leaf = item.Leaf
              // child.leaf = false
              child.orderNum = 'dept' + item.Id
            } else {
              child.className = 'i-male'
              child.orderNum = 'user' + item.Id
            }
            nodeList.push(child)
          }
        })
        resolve(nodeList)
      }).catch(function (error) {
        console.log(error)
      })
    },
    // 是否被包含,是返回true,不是返回false
    isContained (arr, str) {
      let contained = false
      arr.forEach(item => {
        if (item === str) {
          contained = true
        }
      })
      return contained
    },
    // 获取根节点
    getRoot () {
      let self = this
      let postData = {
        controller: 'GTP.Org.Action.CommonObjectService',
        action: 'GetChildOrgUnitListXXNew',
        args: [1001, 0, 'Dept', false, false, true, false, this.authCode, false, true, 2]
      }
      this.$http.post('/vueapi/org.ashx', postData
      ).then((response) => {
        let result = JSON.parse(response.data.Data)
        // console.log(result)
        // let root = {}
        if (self.isContained(self.authUnit.deptVisableParentlds, result[0].Id.toString()) || !self.authUnit.isLimited) {
          let root = result[0]
          root.id = result[0].Id
          root.type = result[0].ObjType
          root.label = result[0].Name
          root.children = []
          root.leaf = result[0].Leaf
          root.className = 'i-root'
          root.orderNum = 'dept' + result[0].Id
          self.data.push(root)
        }
      }).catch(function (error) {
        console.log(error)
      })
    }
  },
  created () {
    this.getAuthDept()
  }
}
</script>

<style>
  #SelectDept{
    /*border-radius: 5px;*/
    /*box-shadow: 0 2px 3px hsla(0,0%,4%,.1), 0 0 0 1px hsla(0,0%,4%,.1);*/
  }
  .org-tree{
    width: 100%;
    height: 100%;
    display: block;
  }
  .custom-tree-node{
    display: flex;
    justify-content: center;
    align-items: center;
  }
  .i-root{
    background:url('../../assets/root.png');
    width: 16px;
    height: 16px;
    display: inline-block;
    background-repeat: no-repeat;
  }
  .i-male{
    background:url('../../assets/male.png');
    width: 16px;
    height: 16px;
    display: inline-block;
    background-repeat: no-repeat;
  }
  .i-dept{
    background:url('../../assets/dept.png');
    width: 16px;
    height: 16px;
    display: inline-block;
    background-repeat: no-repeat;
  }
</style>
