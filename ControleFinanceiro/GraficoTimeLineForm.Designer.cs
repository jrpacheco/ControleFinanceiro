﻿namespace ControleFinanceiro
{
    partial class GraficoTimeLineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficoTimeLineForm));
            this.ReportDataSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.cbSubTipoLancamento = new System.Windows.Forms.ComboBox();
            this.cbTipoLancamento = new System.Windows.Forms.ComboBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDataSourcesBindingSource
            // 
            this.ReportDataSourcesBindingSource.DataMember = "ListaTimeLine";
            this.ReportDataSourcesBindingSource.DataSource = typeof(ControleFinanceiro.ReportDataSources);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "TimeLine";
            reportDataSource1.Value = this.ReportDataSourcesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleFinanceiro.Relatorios.TimeLine.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(757, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(84, 7);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(101, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(84, 35);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(101, 20);
            this.dtpFinal.TabIndex = 2;
            // 
            // cbSubTipoLancamento
            // 
            this.cbSubTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubTipoLancamento.FormattingEnabled = true;
            this.cbSubTipoLancamento.Location = new System.Drawing.Point(201, 34);
            this.cbSubTipoLancamento.Name = "cbSubTipoLancamento";
            this.cbSubTipoLancamento.Size = new System.Drawing.Size(319, 21);
            this.cbSubTipoLancamento.TabIndex = 4;
            // 
            // cbTipoLancamento
            // 
            this.cbTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLancamento.FormattingEnabled = true;
            this.cbTipoLancamento.Location = new System.Drawing.Point(201, 6);
            this.cbTipoLancamento.Name = "cbTipoLancamento";
            this.cbTipoLancamento.Size = new System.Drawing.Size(319, 21);
            this.cbTipoLancamento.TabIndex = 3;
            this.cbTipoLancamento.SelectedIndexChanged += new System.EventHandler(this.cbTipoLancamento_SelectedIndexChanged);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(526, 5);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(104, 50);
            this.btnGerarRelatorio.TabIndex = 5;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Final";
            // 
            // GraficoTimeLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.cbSubTipoLancamento);
            this.Controls.Add(this.cbTipoLancamento);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraficoTimeLineForm";
            this.Text = "Time Line";
            this.Load += new System.EventHandler(this.GraficoTimeLineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSourcesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportDataSourcesBindingSource;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.ComboBox cbSubTipoLancamento;
        private System.Windows.Forms.ComboBox cbTipoLancamento;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}