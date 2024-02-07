using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_SiteType : INotifyPropertyChanged
	{
		private Business_Site_Reference_DataType location_ReferenceField;

		private Location_DataType location_DataField;

		private DateTime as_Of_MomentField;

		private bool as_Of_MomentFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Site_Reference_DataType Location_Reference
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

		[XmlElement(Order = 1)]
		public Location_DataType Location_Data
		{
			get
			{
				return this.location_DataField;
			}
			set
			{
				this.location_DataField = value;
				this.RaisePropertyChanged("Location_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public DateTime As_Of_Moment
		{
			get
			{
				return this.as_Of_MomentField;
			}
			set
			{
				this.as_Of_MomentField = value;
				this.RaisePropertyChanged("As_Of_Moment");
			}
		}

		[XmlIgnore]
		public bool As_Of_MomentSpecified
		{
			get
			{
				return this.as_Of_MomentFieldSpecified;
			}
			set
			{
				this.as_Of_MomentFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_MomentSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
