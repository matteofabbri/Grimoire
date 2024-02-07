using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class International_Assignment_Summary_DataType : INotifyPropertyChanged
	{
		private bool has_International_AssignmentField;

		private bool has_International_AssignmentFieldSpecified;

		private CountryObjectType[] host_Countries_ReferenceField;

		private CountryObjectType home_Country_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Has_International_Assignment
		{
			get
			{
				return this.has_International_AssignmentField;
			}
			set
			{
				this.has_International_AssignmentField = value;
				this.RaisePropertyChanged("Has_International_Assignment");
			}
		}

		[XmlIgnore]
		public bool Has_International_AssignmentSpecified
		{
			get
			{
				return this.has_International_AssignmentFieldSpecified;
			}
			set
			{
				this.has_International_AssignmentFieldSpecified = value;
				this.RaisePropertyChanged("Has_International_AssignmentSpecified");
			}
		}

		[XmlElement("Host_Countries_Reference", Order = 1)]
		public CountryObjectType[] Host_Countries_Reference
		{
			get
			{
				return this.host_Countries_ReferenceField;
			}
			set
			{
				this.host_Countries_ReferenceField = value;
				this.RaisePropertyChanged("Host_Countries_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CountryObjectType Home_Country_Reference
		{
			get
			{
				return this.home_Country_ReferenceField;
			}
			set
			{
				this.home_Country_ReferenceField = value;
				this.RaisePropertyChanged("Home_Country_Reference");
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
