using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Stock_Participation_Rate_Table_Request_ReferencesType : INotifyPropertyChanged
	{
		private Stock_Participation_Rate_TableObjectType[] stock_Participation_Rate_Table_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Stock_Participation_Rate_Table_Reference", Order = 0)]
		public Stock_Participation_Rate_TableObjectType[] Stock_Participation_Rate_Table_Reference
		{
			get
			{
				return this.stock_Participation_Rate_Table_ReferenceField;
			}
			set
			{
				this.stock_Participation_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Participation_Rate_Table_Reference");
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
