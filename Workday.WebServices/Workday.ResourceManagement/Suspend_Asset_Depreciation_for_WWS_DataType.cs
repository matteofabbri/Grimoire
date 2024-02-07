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
	public class Suspend_Asset_Depreciation_for_WWS_DataType : INotifyPropertyChanged
	{
		private Business_AssetObjectType asset_ReferenceField;

		private DateTime suspend_From_DateField;

		private DateTime suspend_To_DateField;

		private bool suspend_To_DateFieldSpecified;

		private Asset_BookObjectType[] restricted_To_Books_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_AssetObjectType Asset_Reference
		{
			get
			{
				return this.asset_ReferenceField;
			}
			set
			{
				this.asset_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Suspend_From_Date
		{
			get
			{
				return this.suspend_From_DateField;
			}
			set
			{
				this.suspend_From_DateField = value;
				this.RaisePropertyChanged("Suspend_From_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Suspend_To_Date
		{
			get
			{
				return this.suspend_To_DateField;
			}
			set
			{
				this.suspend_To_DateField = value;
				this.RaisePropertyChanged("Suspend_To_Date");
			}
		}

		[XmlIgnore]
		public bool Suspend_To_DateSpecified
		{
			get
			{
				return this.suspend_To_DateFieldSpecified;
			}
			set
			{
				this.suspend_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Suspend_To_DateSpecified");
			}
		}

		[XmlElement("Restricted_To_Books_Reference", Order = 3)]
		public Asset_BookObjectType[] Restricted_To_Books_Reference
		{
			get
			{
				return this.restricted_To_Books_ReferenceField;
			}
			set
			{
				this.restricted_To_Books_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_To_Books_Reference");
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
