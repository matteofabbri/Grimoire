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
	public class Organization_Reference_ID_Reference_DataType : INotifyPropertyChanged
	{
		private string organization_Reference_IDField;

		private string organization_NameField;

		private bool include_Organization_ID_in_NameField;

		private bool include_Organization_ID_in_NameFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Organization_Reference_ID
		{
			get
			{
				return this.organization_Reference_IDField;
			}
			set
			{
				this.organization_Reference_IDField = value;
				this.RaisePropertyChanged("Organization_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Organization_ID_in_Name
		{
			get
			{
				return this.include_Organization_ID_in_NameField;
			}
			set
			{
				this.include_Organization_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Organization_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Organization_ID_in_NameSpecified
		{
			get
			{
				return this.include_Organization_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Organization_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Organization_ID_in_NameSpecified");
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
