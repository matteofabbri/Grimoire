using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class RegionType : INotifyPropertyChanged
	{
		private RegionObjectType region_ReferenceField;

		private Region_DataType region_DataField;

		private Simple_Region_DataType simple_Region_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RegionObjectType Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Region_DataType Region_Data
		{
			get
			{
				return this.region_DataField;
			}
			set
			{
				this.region_DataField = value;
				this.RaisePropertyChanged("Region_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Simple_Region_DataType Simple_Region_Data
		{
			get
			{
				return this.simple_Region_DataField;
			}
			set
			{
				this.simple_Region_DataField = value;
				this.RaisePropertyChanged("Simple_Region_Data");
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
