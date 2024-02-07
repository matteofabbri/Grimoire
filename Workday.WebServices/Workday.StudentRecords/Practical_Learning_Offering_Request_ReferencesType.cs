using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Practical_Learning_Offering_Request_ReferencesType : INotifyPropertyChanged
	{
		private Practical_Learning_OfferingObjectType[] practical_Learning_Offering_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Practical_Learning_Offering_Reference", Order = 0)]
		public Practical_Learning_OfferingObjectType[] Practical_Learning_Offering_Reference
		{
			get
			{
				return this.practical_Learning_Offering_ReferenceField;
			}
			set
			{
				this.practical_Learning_Offering_ReferenceField = value;
				this.RaisePropertyChanged("Practical_Learning_Offering_Reference");
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
