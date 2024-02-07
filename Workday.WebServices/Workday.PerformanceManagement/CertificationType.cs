using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class CertificationType : INotifyPropertyChanged
	{
		private CertificationObjectType certification_ReferenceField;

		private Certification_DataType certification_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CertificationObjectType Certification_Reference
		{
			get
			{
				return this.certification_ReferenceField;
			}
			set
			{
				this.certification_ReferenceField = value;
				this.RaisePropertyChanged("Certification_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Certification_DataType Certification_Data
		{
			get
			{
				return this.certification_DataField;
			}
			set
			{
				this.certification_DataField = value;
				this.RaisePropertyChanged("Certification_Data");
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
