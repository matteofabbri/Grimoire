using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Resource_Plan_Line_Requirement_DataType : INotifyPropertyChanged
	{
		private string resource_Plan_Line_Requirement_IDField;

		private Project_Resource_Plan_DetailObjectType resource_Plan_Detail_ReferenceField;

		private Resource_Plan_Requirement_Parameter_DataType[] resource_Plan_Line_Requirement_Parameter_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Resource_Plan_Line_Requirement_ID
		{
			get
			{
				return this.resource_Plan_Line_Requirement_IDField;
			}
			set
			{
				this.resource_Plan_Line_Requirement_IDField = value;
				this.RaisePropertyChanged("Resource_Plan_Line_Requirement_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Resource_Plan_DetailObjectType Resource_Plan_Detail_Reference
		{
			get
			{
				return this.resource_Plan_Detail_ReferenceField;
			}
			set
			{
				this.resource_Plan_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Plan_Detail_Reference");
			}
		}

		[XmlElement("Resource_Plan_Line_Requirement_Parameter_Data", Order = 2)]
		public Resource_Plan_Requirement_Parameter_DataType[] Resource_Plan_Line_Requirement_Parameter_Data
		{
			get
			{
				return this.resource_Plan_Line_Requirement_Parameter_DataField;
			}
			set
			{
				this.resource_Plan_Line_Requirement_Parameter_DataField = value;
				this.RaisePropertyChanged("Resource_Plan_Line_Requirement_Parameter_Data");
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
