<template>
  <div class="detiallist">
    <el-pagination class="lo-el-pagination-top"
                   v-show="totalCount>20"
                   @size-change="handleSizeChange"
                   @current-change="handleCurrentChange"
                   :current-page="pageIndex"
                   :page-sizes="[10, 20, 50, 100]"
                   :page-size="pageSize"
                   layout="total, sizes, prev, pager, next, jumper"
                   :total="totalCount">
    </el-pagination>
    <el-table :data="tableData"
              :class="{'first-load': firstLoad}"
              border
              :default-sort="{prop: 'createTime', order: 'descending'}"
              style="width: 100%">
      <el-table-column prop="chuLiRen"
                       label="处理人"
                       width="100">
      </el-table-column>
      <el-table-column prop="chuLiJieDian"
                       width="100"
                       label="处理节点">
      </el-table-column>
      <el-table-column prop="chuLiShiJian"
                       width="165"
                       class-name="td-date"
                       label="处理时间">
      </el-table-column>
      <el-table-column prop="chuLiJieGuo"
                       label="处理结果"
                       width="150">
      </el-table-column>
      <el-table-column prop="chuLiYiJian"
                       label-class-name="text_left"
                       class-name="text_left"
                       label="处理意见">
        <template slot-scope="scope">
          <div class="el-table-td-div-overflow"
               :title="scope.row.chuLiYiJian">{{ scope.row.chuLiYiJian}}</div>
        </template>
      </el-table-column>
      <el-table-column prop="chaKanShiJian"
                       width="165"
                       label="查看时间"
                       class-name="td-date">
      </el-table-column>
      <el-table-column prop="tiJiaoRen"
                       label="提交人"
                       width="100">
      </el-table-column>
    </el-table>
    <el-pagination class="lo-el-pagination-bottom"
                   v-show="totalCount>20"
                   @size-change="handleSizeChange"
                   @current-change="handleCurrentChange"
                   :current-page="pageIndex"
                   :page-sizes="[10, 20, 50, 100]"
                   :page-size="pageSize"
                   layout="total, sizes, prev, pager, next, jumper"
                   :total="totalCount">
    </el-pagination>
  </div>
</template>

<script>
import { getChuLiJiLuPageList } from '@/services/XiangQing.api'
export default {
  name: 'WorkflowSteps',
  data () {
    return {
      tableData: [], // 表格数组
      pageIndex: 1, // 页数
      pageSize: 10, // 条数
      totalCount: 0, // 总数量
      firstLoad: true// 处理华加载动画....
    }
  },
  props: {
    // 公文id
    flowId: {
      type: Number,
      default: function () {
        return 0
      }
    },
    // 任务id
    taskId: {
      type: Number,
      default: function () {
        return 0
      }
    }
  },
  mounted () {
    this.getTableData()
  },
  methods: {
    handleSizeChange (val) {
      this.pageIndex = 1
      this.pageSize = val
      this.getTableData()
    },
    handleCurrentChange (val) {
      this.pageIndex = val
      this.getTableData()
    },
    // 获取分送数据 taskId = 0 时，只查，否者先改查看时间，在查
    getTableData () {
      let self = this
      getChuLiJiLuPageList({
        'pageIndex': self.pageIndex,
        'pageSize': self.pageSize,
        'gwId': self.flowId
      }).then(res => {
        self.firstLoad = false
        self.tableData = res.data
        self.totalCount = res.pageing.total
      })
    }
  }
}
</script>
<style lang="css" scoped>
.column_time {
  color: #919191 !important;
  text-align: left !important;
}
.column_title {
  text-align: center !important;
}
.el-table--border {
  height: auto !important;
}
.detiallist .lo-el-pagination-top,
.detiallist .lo-el-pagination-bottom {
  text-align: right;
  border: 1px solid #e1e1e1;
  padding: 5px 15px;
}
.detiallist .lo-el-pagination-top {
  border-bottom: none;
}
.detiallist .lo-el-pagination-bottom {
  border-top: none;
}
</style>
