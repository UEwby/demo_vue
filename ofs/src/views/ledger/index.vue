<template>
  <div class="ledger">
    <div class="button-group">
      <el-button type="primary"
                 size="mini">新建</el-button>
      <el-button type="primary"
                 size="mini"
                 plain>提交</el-button>
      <el-button type="primary"
                 size="mini"
                 plain>删除</el-button>
      <el-button type="primary"
                 size="mini"
                 plain>导出当前页</el-button>
      <el-button type="primary"
                 size="mini"
                 plain>导出全部</el-button>
      <el-button type="primary"
                 size="mini"
                 plain>导出所选任务</el-button>
    </div>
    <div class="list-wrap">
      <el-pagination class="lo-el-pagination-top"
                     @size-change="handleSizeChange"
                     @current-change="handleCurrentChange"
                     :current-page="currentPage4"
                     :page-sizes="[100, 200, 300, 400]"
                     :page-size="100"
                     layout="total, sizes, prev, pager, next, jumper"
                     :total="400">
      </el-pagination>
      <el-table :data="tableData"
                highlight-current-row
                border
                size="small"
                style="width: 100%"
                @selection-change="handleSelectionChange">
        <el-table-column type="selection"
                         width="35">
        </el-table-column>
        <el-table-column prop="date"
                         label="日期"
                         width="180">
        </el-table-column>
        <el-table-column prop="name"
                         label="姓名"
                         width="180">
        </el-table-column>
        <el-table-column prop="address"
                         label-class-name="un-dorder-r"
                         label="地址">
        </el-table-column>
      </el-table>
      <el-pagination class="lo-el-pagination-bottom"
                     @size-change="handleSizeChange"
                     @current-change="handleCurrentChange"
                     :current-page="currentPage4"
                     :page-sizes="[100, 200, 300, 400]"
                     :page-size="100"
                     layout="total, sizes, prev, pager, next, jumper"
                     :total="400">
      </el-pagination>
      <user-selector
        @sendData="receptData"
      ></user-selector>
    </div>
  </div>
</template>

<script>
import { UserSelector, DeptSelector } from '@/components/OfsForm'
export default {
  name: 'ledger',
  components: { UserSelector, DeptSelector },
  data () {
    return {
      selectedUser: '',
      currentPage4: 4,
      tableHeight: window.innerHeight - 165,
      tableData: [{
        date: '2016-05-02',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1518 弄'
      }, {
        date: '2016-05-04',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1517 弄'
      }, {
        date: '2016-05-01',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1519 弄'
      }, {
        date: '2016-05-01',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1519 弄'
      }, {
        date: '2016-05-01',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1519 弄'
      }, {
        date: '2016-05-01',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1519 弄'
      }, {
        date: '2016-05-01',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1519 弄'
      }]
    }
  },
  methods: {
    handleSizeChange (val) {
      console.log(`每页 ${val} 条`)
    },
    handleCurrentChange (val) {
      console.log(`当前页: ${val}`)
    },
    handleSelectionChange (val) {
      this.multipleSelection = val
    },
    // 接受选择返回的用户
    receptData (user) {
      this.selectedUser = user
    }
  }
}
</script>

<style scoped lang="scss">
.ledger {
  padding: 20px;
}
.list-wrap {
}
.button-group {
  margin-bottom: 15px;
}
.ledger .lo-el-pagination-top,
.ledger .lo-el-pagination-bottom {
  text-align: right;
  border: 1px solid #e1e1e1;
  padding: 5px 15px;
}
.ledger .lo-el-pagination-top {
  border-bottom: none;
}
.ledger .lo-el-pagination-bottom {
  border-top: none;
}
</style>
<style>
  .ledger .el-table th {
    background-color: #F3F3F3;
  }
  .ledger .el-table .el-table__header-wrapper th.un-dorder-r{
    border-right: none;
  }
</style>
