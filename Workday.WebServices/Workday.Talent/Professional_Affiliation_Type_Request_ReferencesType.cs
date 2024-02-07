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
	public class Professional_Affiliation_Type_Request_ReferencesType : INotifyPropertyChanged
	{
		private Professional_Affiliation_TypeObjectType[] professional_Affiliation_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Professional_Affiliation_Type_Reference", Order = 0)]
		public Professional_Affiliation_TypeObjectType[] Professional_Affiliation_Type_Reference
		{
			get
			{
				return this.professional_Affiliation_Type_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Type_Reference");
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
