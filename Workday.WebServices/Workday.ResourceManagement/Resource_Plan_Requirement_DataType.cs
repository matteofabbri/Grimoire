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
	public class Resource_Plan_Requirement_DataType : INotifyPropertyChanged
	{
		private string resource_Plan_IDField;

		private Resource_Plan_Line_Requirement_DataType[] resource_Plan_Line_Requirement_DataField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Resource_Plan_ID
		{
			get
			{
				return this.resource_Plan_IDField;
			}
			set
			{
				this.resource_Plan_IDField = value;
				this.RaisePropertyChanged("Resource_Plan_ID");
			}
		}

		[XmlElement("Resource_Plan_Line_Requirement_Data", Order = 1)]
		public Resource_Plan_Line_Requirement_DataType[] Resource_Plan_Line_Requirement_Data
		{
			get
			{
				return this.resource_Plan_Line_Requirement_DataField;
			}
			set
			{
				this.resource_Plan_Line_Requirement_DataField = value;
				this.RaisePropertyChanged("Resource_Plan_Line_Requirement_Data");
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
