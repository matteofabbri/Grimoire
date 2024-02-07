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
	public class Resource_Forecast__HV__DataType : INotifyPropertyChanged
	{
		private string resource_Forecast_IDField;

		private ProjectObjectType project_ReferenceField;

		private Resource_Forecast_Configuration_DataType[] resource_Forecast_Configuration_DataField;

		private Resource_Forecast_Line__HV__DataType[] resource_Forecast_Line_DataField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Resource_Forecast_ID
		{
			get
			{
				return this.resource_Forecast_IDField;
			}
			set
			{
				this.resource_Forecast_IDField = value;
				this.RaisePropertyChanged("Resource_Forecast_ID");
			}
		}

		[XmlElement(Order = 1)]
		public ProjectObjectType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement("Resource_Forecast_Configuration_Data", Order = 2)]
		public Resource_Forecast_Configuration_DataType[] Resource_Forecast_Configuration_Data
		{
			get
			{
				return this.resource_Forecast_Configuration_DataField;
			}
			set
			{
				this.resource_Forecast_Configuration_DataField = value;
				this.RaisePropertyChanged("Resource_Forecast_Configuration_Data");
			}
		}

		[XmlElement("Resource_Forecast_Line_Data", Order = 3)]
		public Resource_Forecast_Line__HV__DataType[] Resource_Forecast_Line_Data
		{
			get
			{
				return this.resource_Forecast_Line_DataField;
			}
			set
			{
				this.resource_Forecast_Line_DataField = value;
				this.RaisePropertyChanged("Resource_Forecast_Line_Data");
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
