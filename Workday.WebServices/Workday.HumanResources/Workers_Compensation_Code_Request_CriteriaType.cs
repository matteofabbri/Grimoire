using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workers_Compensation_Code_Request_CriteriaType : INotifyPropertyChanged
	{
		private CountryObjectType[] country_ReferenceField;

		private Country_RegionObjectType[] country_Subregion_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Country_Reference", Order = 0)]
		public CountryObjectType[] Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Country_Subregion_Reference", Order = 1)]
		public Country_RegionObjectType[] Country_Subregion_Reference
		{
			get
			{
				return this.country_Subregion_ReferenceField;
			}
			set
			{
				this.country_Subregion_ReferenceField = value;
				this.RaisePropertyChanged("Country_Subregion_Reference");
			}
		}

		[XmlElement("Location_Reference", Order = 2)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
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
