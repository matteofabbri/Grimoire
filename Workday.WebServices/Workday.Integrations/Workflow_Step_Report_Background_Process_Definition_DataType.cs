using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workflow_Step_Report_Background_Process_Definition_DataType : INotifyPropertyChanged
	{
		private Document_TypeObjectType document_Type_ReferenceField;

		private object itemField;

		private object item1Field;

		private Report_Parameter_Initialization_DataType[] report_Parameter_Initialization_DataField;

		private decimal file_Expiration_in_DaysField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Document_TypeObjectType Document_Type_Reference
		{
			get
			{
				return this.document_Type_ReferenceField;
			}
			set
			{
				this.document_Type_ReferenceField = value;
				this.RaisePropertyChanged("Document_Type_Reference");
			}
		}

		[XmlElement("Custom_Business_Form_Layout_Reference", typeof(Custom_Business_Form_LayoutObjectType), Order = 1), XmlElement("Delivered_Business_Form_Layout_Reference", typeof(Delivered_Business_Form_LayoutObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Referenced_Task_Reference", typeof(Referenced_TaskObjectType), Order = 2), XmlElement("Tenanted_Report_Definition_Reference", typeof(Custom_Report_DefinitionObjectType), Order = 2)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement("Report_Parameter_Initialization_Data", Order = 3)]
		public Report_Parameter_Initialization_DataType[] Report_Parameter_Initialization_Data
		{
			get
			{
				return this.report_Parameter_Initialization_DataField;
			}
			set
			{
				this.report_Parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Report_Parameter_Initialization_Data");
			}
		}

		[XmlElement(Order = 4)]
		public decimal File_Expiration_in_Days
		{
			get
			{
				return this.file_Expiration_in_DaysField;
			}
			set
			{
				this.file_Expiration_in_DaysField = value;
				this.RaisePropertyChanged("File_Expiration_in_Days");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
