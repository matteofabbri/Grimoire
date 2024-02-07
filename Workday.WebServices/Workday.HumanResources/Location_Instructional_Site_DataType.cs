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
	public class Location_Instructional_Site_DataType : INotifyPropertyChanged
	{
		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private decimal instructional_Site_Data_CapacityField;

		private bool offSiteField;

		private bool offSiteFieldSpecified;

		private bool instructional_Use_OnlyField;

		private bool instructional_Use_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_UnitObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Instructional_Site_Data_Capacity
		{
			get
			{
				return this.instructional_Site_Data_CapacityField;
			}
			set
			{
				this.instructional_Site_Data_CapacityField = value;
				this.RaisePropertyChanged("Instructional_Site_Data_Capacity");
			}
		}

		[XmlElement("Off-Site", Order = 2)]
		public bool OffSite
		{
			get
			{
				return this.offSiteField;
			}
			set
			{
				this.offSiteField = value;
				this.RaisePropertyChanged("OffSite");
			}
		}

		[XmlIgnore]
		public bool OffSiteSpecified
		{
			get
			{
				return this.offSiteFieldSpecified;
			}
			set
			{
				this.offSiteFieldSpecified = value;
				this.RaisePropertyChanged("OffSiteSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Instructional_Use_Only
		{
			get
			{
				return this.instructional_Use_OnlyField;
			}
			set
			{
				this.instructional_Use_OnlyField = value;
				this.RaisePropertyChanged("Instructional_Use_Only");
			}
		}

		[XmlIgnore]
		public bool Instructional_Use_OnlySpecified
		{
			get
			{
				return this.instructional_Use_OnlyFieldSpecified;
			}
			set
			{
				this.instructional_Use_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Instructional_Use_OnlySpecified");
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
