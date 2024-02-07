using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Non_Effective_Dated_Web_Service_Additional_DataType : INotifyPropertyChanged
	{
		private XmlElement[] anyField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlAnyElement(Order = 0)]
		public XmlElement[] Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
				this.RaisePropertyChanged("Any");
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
