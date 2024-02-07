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
	public class Resource_Forecast_Request_ReferencesType : INotifyPropertyChanged
	{
		private Resource_ForecastObjectType[] resource_Forecast_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Resource_Forecast_Reference", Order = 0)]
		public Resource_ForecastObjectType[] Resource_Forecast_Reference
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
