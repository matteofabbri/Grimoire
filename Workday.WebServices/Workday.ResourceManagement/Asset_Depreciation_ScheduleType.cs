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
	public class Asset_Depreciation_ScheduleType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType asset_Book_Configuration_ReferenceField;

		private Asset_Depreciation_Schedule_DataType[] asset_Book_Configuration_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Asset_Book_Configuration_Reference
		{
			get
			{
				return this.asset_Book_Configuration_ReferenceField;
			}
			set
			{
				this.asset_Book_Configuration_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Configuration_Reference");
			}
		}

		[XmlElement("Asset_Book_Configuration_Data", Order = 1)]
		public Asset_Depreciation_Schedule_DataType[] Asset_Book_Configuration_Data
		{
			get
			{
				return this.asset_Book_Configuration_DataField;
			}
			set
			{
				this.asset_Book_Configuration_DataField = value;
				this.RaisePropertyChanged("Asset_Book_Configuration_Data");
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
