Namespace ConditionalFormatting_Example

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.button1 = New System.Windows.Forms.Button()
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.IsSplitterFixed = True
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.treeList1)
            Me.splitContainer1.Panel1MinSize = 0
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.button1)
            Me.splitContainer1.Panel2.Tag = "1"
            Me.splitContainer1.Size = New System.Drawing.Size(342, 543)
            Me.splitContainer1.SplitterDistance = 470
            Me.splitContainer1.TabIndex = 0
            ' 
            ' treeList1
            ' 
            Me.treeList1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((64)))))), (CInt(((CByte((0)))))))
            Me.treeList1.Appearance.FocusedCell.Options.UseFont = True
            Me.treeList1.Appearance.FocusedCell.Options.UseForeColor = True
            Me.treeList1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsView.ShowColumns = False
            Me.treeList1.OptionsView.ShowIndicator = False
            Me.treeList1.Size = New System.Drawing.Size(338, 466)
            Me.treeList1.TabIndex = 0
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Object]
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            ' 
            ' button1
            ' 
            Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.button1.Font = New System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.button1.Location = New System.Drawing.Point(0, 0)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(338, 65)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Run"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(342, 543)
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "Form1"
            Me.Text = "Conditional Formatting Examples"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private splitContainer1 As System.Windows.Forms.SplitContainer

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private button1 As System.Windows.Forms.Button

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace
