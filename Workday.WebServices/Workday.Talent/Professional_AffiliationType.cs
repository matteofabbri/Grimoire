using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Professional_AffiliationType : INotifyPropertyChanged
	{
		private Professional_AffiliationObjectType professional_Affiliation_ReferenceField;

		private Professional_Affiliation_DataType[] professional_Affiliation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Professional_AffiliationObjectType Professional_Affiliation_Reference
		{
			get
			{
				return this.professional_Affiliation_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Reference");
			}
		}

		[XmlElement("Professional_Affiliation_Data", Order = 1)]
		public Professional_Affiliation_DataType[] Professional_Affiliation_Data
		{
			get
			{
				return this.professional_Affiliation_DataField;
			}
			set
			{
				this.professional_Affiliation_DataField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Data");
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
