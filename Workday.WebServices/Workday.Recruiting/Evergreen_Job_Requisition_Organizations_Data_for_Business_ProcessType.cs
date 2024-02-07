using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Evergreen_Job_Requisition_Organizations_Data_for_Business_ProcessType : INotifyPropertyChanged
	{
		private Organization_Assignments_for_Job_Requisition_DataType organization_Assignments_for_Job_Requisition_DataField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Organization_Assignments_for_Job_Requisition_DataType Organization_Assignments_for_Job_Requisition_Data
		{
			get
			{
				return this.organization_Assignments_for_Job_Requisition_DataField;
			}
			set
			{
				this.organization_Assignments_for_Job_Requisition_DataField = value;
				this.RaisePropertyChanged("Organization_Assignments_for_Job_Requisition_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace_All
		{
			get
			{
				return this.replace_AllField;
			}
			set
			{
				this.replace_AllField = value;
				this.RaisePropertyChanged("Replace_All");
			}
		}

		[XmlIgnore]
		public bool Replace_AllSpecified
		{
			get
			{
				return this.replace_AllFieldSpecified;
			}
			set
			{
				this.replace_AllFieldSpecified = value;
				this.RaisePropertyChanged("Replace_AllSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
