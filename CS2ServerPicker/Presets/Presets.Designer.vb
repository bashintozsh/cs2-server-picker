﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PresetsDataGridView = New System.Windows.Forms.DataGridView()
        Me.PresetList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresetServerListDataGridView = New System.Windows.Forms.DataGridView()
        Me.PresetServers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockPresetServersButton = New System.Windows.Forms.Button()
        Me.AddPresetFormButton = New System.Windows.Forms.Button()
        Me.DeletePresetFormButton = New System.Windows.Forms.Button()
        CType(Me.PresetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresetServerListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PresetsDataGridView
        '
        Me.PresetsDataGridView.AllowUserToAddRows = False
        Me.PresetsDataGridView.AllowUserToDeleteRows = False
        Me.PresetsDataGridView.AllowUserToOrderColumns = True
        Me.PresetsDataGridView.AllowUserToResizeRows = False
        Me.PresetsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresetsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PresetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresetsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PresetList})
        Me.PresetsDataGridView.Location = New System.Drawing.Point(30, 52)
        Me.PresetsDataGridView.Name = "PresetsDataGridView"
        Me.PresetsDataGridView.RowHeadersVisible = False
        Me.PresetsDataGridView.RowHeadersWidth = 51
        Me.PresetsDataGridView.RowTemplate.Height = 24
        Me.PresetsDataGridView.Size = New System.Drawing.Size(243, 297)
        Me.PresetsDataGridView.TabIndex = 0
        '
        'PresetList
        '
        Me.PresetList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PresetList.HeaderText = "Presets"
        Me.PresetList.MinimumWidth = 6
        Me.PresetList.Name = "PresetList"
        Me.PresetList.ReadOnly = True
        Me.PresetList.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PresetServerListDataGridView
        '
        Me.PresetServerListDataGridView.AllowUserToAddRows = False
        Me.PresetServerListDataGridView.AllowUserToDeleteRows = False
        Me.PresetServerListDataGridView.AllowUserToOrderColumns = True
        Me.PresetServerListDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresetServerListDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PresetServerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresetServerListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PresetServers})
        Me.PresetServerListDataGridView.Location = New System.Drawing.Point(299, 52)
        Me.PresetServerListDataGridView.Name = "PresetServerListDataGridView"
        Me.PresetServerListDataGridView.ReadOnly = True
        Me.PresetServerListDataGridView.RowHeadersVisible = False
        Me.PresetServerListDataGridView.RowHeadersWidth = 51
        Me.PresetServerListDataGridView.RowTemplate.Height = 24
        Me.PresetServerListDataGridView.Size = New System.Drawing.Size(458, 362)
        Me.PresetServerListDataGridView.TabIndex = 1
        '
        'PresetServers
        '
        Me.PresetServers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PresetServers.HeaderText = "Preset Servers"
        Me.PresetServers.MinimumWidth = 6
        Me.PresetServers.Name = "PresetServers"
        Me.PresetServers.ReadOnly = True
        Me.PresetServers.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'BlockPresetServersButton
        '
        Me.BlockPresetServersButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BlockPresetServersButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlockPresetServersButton.Location = New System.Drawing.Point(54, 368)
        Me.BlockPresetServersButton.Name = "BlockPresetServersButton"
        Me.BlockPresetServersButton.Size = New System.Drawing.Size(181, 46)
        Me.BlockPresetServersButton.TabIndex = 4
        Me.BlockPresetServersButton.Text = "Block By Selected Preset"
        Me.BlockPresetServersButton.UseVisualStyleBackColor = False
        '
        'AddPresetFormButton
        '
        Me.AddPresetFormButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPresetFormButton.Location = New System.Drawing.Point(533, 22)
        Me.AddPresetFormButton.Name = "AddPresetFormButton"
        Me.AddPresetFormButton.Size = New System.Drawing.Size(109, 24)
        Me.AddPresetFormButton.TabIndex = 8
        Me.AddPresetFormButton.Text = "Add Preset"
        Me.AddPresetFormButton.UseVisualStyleBackColor = True
        '
        'DeletePresetFormButton
        '
        Me.DeletePresetFormButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeletePresetFormButton.Location = New System.Drawing.Point(648, 22)
        Me.DeletePresetFormButton.Name = "DeletePresetFormButton"
        Me.DeletePresetFormButton.Size = New System.Drawing.Size(109, 24)
        Me.DeletePresetFormButton.TabIndex = 9
        Me.DeletePresetFormButton.Text = "Delete Preset"
        Me.DeletePresetFormButton.UseVisualStyleBackColor = True
        '
        'Presets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 438)
        Me.Controls.Add(Me.DeletePresetFormButton)
        Me.Controls.Add(Me.AddPresetFormButton)
        Me.Controls.Add(Me.BlockPresetServersButton)
        Me.Controls.Add(Me.PresetServerListDataGridView)
        Me.Controls.Add(Me.PresetsDataGridView)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Presets"
        Me.Text = "Presets"
        CType(Me.PresetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresetServerListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PresetsDataGridView As DataGridView
    Friend WithEvents PresetServerListDataGridView As DataGridView
    Friend WithEvents BlockPresetServersButton As Button
    Friend WithEvents AddPresetFormButton As Button
    Friend WithEvents DeletePresetFormButton As Button
    Friend WithEvents PresetList As DataGridViewTextBoxColumn
    Friend WithEvents PresetServers As DataGridViewTextBoxColumn
End Class
