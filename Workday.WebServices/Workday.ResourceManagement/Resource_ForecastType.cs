using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Resource_ForecastType : INotifyPropertyChanged
	{
		private string resource_Forecast_IDField;

		private Resource_ForecastObjectType resource_Forecast_ReferenceField;

		private ProjectObjectType project_ReferenceField;

		private Resource_Forecast_Configuration_Get_Webservice_DataType[] resource_Forecast_Configuration_DataField;

		private Resource_Forecast_Line_View_Get_WebserviceType[] resource_Forecast_Line_DataField;

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
		public Resource_ForecastObjectType Resource_Forecast_Reference
		{
			get
			{
				return this.resource_Forecast_ReferenceField;
			}
			set
			{
				this.resource_Forecast_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Forecast_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Resource_Forecast_Configuration_Data", Order = 3)]
		public Resource_Forecast_Configuration_Get_Webservice_DataType[] Resource_Forecast_Configuration_Data
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

		[XmlElement("Resource_Forecast_Line_Data", Order = 4)]
		public Resource_Forecast_Line_View_Get_WebserviceType[] Resource_Forecast_Line_Data
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
