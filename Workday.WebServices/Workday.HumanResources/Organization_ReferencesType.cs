using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(Organization_ReferencesRootType)), XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organization_ReferencesType : INotifyPropertyChanged
	{
		private Organization_Reference_WWSType[] organization_ReferenceField;

		private DateTime as_Of_DateField;

		private bool as_Of_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public Organization_Reference_WWSType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime As_Of_Date
		{
			get
			{
				return this.as_Of_DateField;
			}
			set
			{
				this.as_Of_DateField = value;
				this.RaisePropertyChanged("As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_DateSpecified
		{
			get
			{
				return this.as_Of_DateFieldSpecified;
			}
			set
			{
				this.as_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_DateSpecified");
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
