<template>
  <div class="user-selector">
    <div class="selector-txt">
      <el-input
        size="mini"
        v-model="conValue"
        class="selector-input"
        readonly>
        <i slot="suffix"
           v-if="clearIconStatus"
           @click="clearValue"
           class="el-input__icon  el-icon-close"></i>
        <i slot="suffix"
           @click="showStatus = true"
           class="el-input__icon el-icon-search"></i>
      </el-input>
    </div>
    <el-dialog
      :close-on-click-modal="false"
      width="690px"
      class="user-selector-dlg"
      title="选择人员"
      :before-close="closeDialog"
      :close-on-press-escape="false"
      :visible.sync="showStatus">
      <div class="lo-dialog__body" :class="{'border': !isQuery}">
        <el-input
          class="user-query"
          placeholder="输入关键字"
          size="mini"
          @keyup.native="queryUser"
          v-model="filterText">
        </el-input>
        <div
          v-if="isQuery"
          class="query-list-wrap">
          <el-table
            class="query-list"
            empty-text=" "
            height="372"
            highlight-current-row
            ref="queryTable"
            :data="queryData"
            size="mini"
            @current-change="singleCurrChange"
            style="width: 632px;">
            <el-table-column
              width="120px"
              label="姓名">
              <template slot-scope="scope">
                <span class="ellipsis user" :title="scope.row.name"
                      :class="{'user-male': scope.row.sex === '0', 'user-female': scope.row.sex === '1'}"
                      v-text="scope.row.name">
                  <span>{{scope.row.name}}</span>
                </span>
              </template>
            </el-table-column>
            <el-table-column
              width="240px"
              label="部门">
              <template slot-scope="scope">
                <span class="ellipsis" :title="scope.row.deptName">
                  {{scope.row.deptName}}
                </span>
              </template>
            </el-table-column>
            <el-table-column
              label="全路径">
              <template slot-scope="scope">
                <span class="ellipsis" :title="scope.row.fullName">
                  {{scope.row.fullName}}
                </span>
              </template>
            </el-table-column>
          </el-table>
          <el-pagination class="lo-el-pagination-bottom"
                         small
                         @size-change="handleSizeChange"
                         @current-change="handleCurrentChange"
                         :current-page="currentPage"
                         :page-sizes="[100, 200, 300, 400]"
                         :page-size="100"
                         layout="total, sizes, prev, pager, next, jumper"
                         :total="400">
          </el-pagination>
        </div>
        <el-tree :data="dataList"
                 v-if="!isQuery"
                 empty-text=""
                 class="lo-el-tree"
                 :props="defaultProps"
                 highlight-current
                 :expand-on-click-node="false"
                 @node-click="handleNodeClick"
        ></el-tree>
      </div>
      <div class="lo-footer">
        <el-button type="primary" size="mini" @click="sendData">确定</el-button>
        <el-button type="primary" size="mini" plain @click="closeDialog">取消</el-button>
      </div>
    </el-dialog>
  </div>
</template>

<script>
export default {
  name: 'UserSelector',
  props: {
  },
  data () {
    return {
      selectorTxt: false,
      conValue: '张胖胖',
      showStatus: false,
      clearIconStatus: true,
      filterText: '',
      defaultProps: {
        children: 'children',
        label: 'name',
        isLeaf: 'isLeaf'
      },
      currentPage: 1,
      queryData: [
        {
          id: 212,
          name: '张XXewewewewewewe',
          fullName: '产品中心/技术平台部rteoteutoewroeirewirporiporiewriwo',
          deptName: '技术平台部wewewewewewewe',
          fullId: '1/1102',
          sex: '0'
        }, {
          id: 213,
          name: 'BXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1103',
          sex: '0'
        }, {
          id: 214,
          name: 'CXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1104',
          sex: '1'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }, {
          id: 215,
          name: 'DXX',
          fullName: '产品中心/技术平台部',
          deptName: '技术平台部',
          fullId: '1/1105',
          sex: '0'
        }
      ],
      dataList: [
        {
          pid: 0,
          id: 1,
          name: '广联达公司',
          children: [
            {
              pid: 0,
              id: 2,
              name: '广联大天下',
              children: [
                {
                  pid: 1,
                  id: 21,
                  name: '产品中心',
                  children: [
                    {
                      pid: 21,
                      id: 211,
                      name: '技术平台部',
                      isLeaf: false,
                      fullName: '产品中心/技术平台部',
                      fullId: '1/1101',
                      sex: '',
                      children: [
                        {
                          pid: 211,
                          id: 212,
                          name: '张XX',
                          isLeaf: true,
                          fullName: '产品中心/技术平台部',
                          fullId: '1/1101',
                          sex: ''
                        }, {
                          pid: 211,
                          id: 213,
                          name: 'BXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 214,
                          name: 'CXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 215,
                          name: 'DXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 216,
                          name: 'EXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 217,
                          name: 'FXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 218,
                          name: 'GXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 219,
                          name: 'HXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 220,
                          name: 'JXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 221,
                          name: 'KXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 222,
                          name: 'LXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 223,
                          name: 'OXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 224,
                          name: 'PXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 225,
                          name: 'QXX',
                          isLeaf: true
                        }, {
                          pid: 211,
                          id: 226,
                          name: 'RXX',
                          isLeaf: true
                        }
                      ]
                    }
                  ]
                }
              ]
            }
          ]
        }
      ],
      selectUser: {},
      isQuery: false,
      ranges: ''
    }
  },
  methods: {
    clearValue () {
      this.conValue = ''
      this.clearIconStatus = false
    },
    closeDialog () {
      this.showStatus = false
    },
    handleSizeChange (val) {
      console.log(`每页 ${val} 条`)
    },
    handleCurrentChange (val) {
      console.log(`当前页: ${val}`)
    },
    sendData () {
      if (!this.selectUser.id) {
        return
      }
      this.conValue = this.selectUser.name
      this.closeDialog()
    },
    handleNodeClick (data, Node, zuJian) {
      if (data.isLeaf) {
        this.selectUser = data
      } else {
        // debugger
        zuJian.$el.querySelector('.el-tree-node__content').style.background = '#fff'
        this.selectUser = {}
      }
      console.log(data)
      console.log(Node)
      console.log(zuJian)
    },
    queryUser (val) {
      this.isQuery = !!this.filterText
      if (this.filterText) {
      }
    },
    singleCurrChange (currentRow, oldCurrentRow) {
      this.selectUser = currentRow
      console.log(this.selectUser)
    }
  },
  watch: {
    filterText (val) {
      this.isQuery = !!val
    },
    conValue () {
      this.clearIconStatus = !!this.conValue
    }
  },
  filters: {
  },
  mounted () {
  }
}
</script>

<style scoped lang="scss">
  .user-selector {
  }
  .user-selector .selector-txt{
    max-width: 200px;
  }
  .user-selector .selector-txt .el-icon-close{
    cursor: pointer;
    line-height: 26px;
  }
  .user-selector .selector-txt .el-icon-search{
    cursor: pointer;
    line-height: 26px;
    background: #ddd;
  }
  .user-selector .lo-dialog__body.border {
  }
  .user-selector .lo-dialog__body {
    display: flex;
    justify-content: flex-start;
    flex-direction: column;
    flex-wrap: wrap;
    height: 466px;

    padding: 8px;
    border: 1px solid #E1E1E1;
  }
  .user-selector .user-query {
    margin-bottom: 15px;
    height: 28px;
  }
  .user-selector .lo-el-tree {
    flex: 1;
    overflow-y: scroll;
  }
  .user-selector .lo-footer {
    margin-top: 20px;
    text-align: right;
  }
  .user-selector .query-list {
    padding: 0;
    margin: 0;
  }
  .user-selector .query-list li {
    display: flex;
    justify-content: flex-start;
    align-items: center;
  }
  .user-selector .query-list .user {
    padding-left: 20px;
    background: url("../../../assets/imgs/icon-male.png") no-repeat 0 center;
    background-size: 13px 15px;
  }
  .user-selector .query-list .user.user-male {
    background-image: url("../../../assets/imgs/icon-male.png");
  }
  .user-selector .query-list .user.user-female {
    background-image: url("../../../assets/imgs/icon-female.png");
  }
  .ellipsis{
    display: block;
    text-overflow:ellipsis;
    white-space:nowrap;
    overflow:hidden;
    color: #393939;
    text-decoration: none;
    text-align: left;
    cursor: pointer;
  }
  .lo-el-pagination-bottom {
    padding: 10px 5px 0px;
  }
</style>
<style>
  /*==== 局部定义 ====*/
  /*滚动条的宽度*/
  ::-webkit-scrollbar {
    width: 7px;
    height: 7px;
  }
  /*滚动条的滑块*/
  ::-webkit-scrollbar-thumb {
    background: #E2E3E8;
    border-radius: 5px;
    cursor: pointer;
  }
  .user-selector .el-table__body-wrapper::-webkit-scrollbar {
      width: 7px;
      height: 7px;
    }
  .user-selector .el-table__body-wrapper::-webkit-scrollbar-thumb {
    background: #E2E3E8;
    border-radius: 5px;
    cursor: pointer;
  }
  .user-selector .selector-txt .el-input__suffix {
    right: 0;
    border-radius: 0 5px 5px 0;
    height: 26px;
    margin-top: 1px;
    margin-right: 1px;
  }
</style>
